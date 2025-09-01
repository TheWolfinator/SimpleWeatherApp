using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using SimpleWeatherApp.Core.Deserializers;
using SimpleWeatherApp.Core.Models;
using SimpleWeatherApp.Core.Options;
using SimpleWeatherApp.Core.Services;

public class WeatherService : IWeatherService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IWeatherDeserializerFactory _deserializerFactory;
    private readonly OpenWeatherMapOptions _options;
    private readonly ILogger<WeatherService> _logger;
    public WeatherService(
        IHttpClientFactory httpClientFactory,
        IWeatherDeserializerFactory deserializerFactory,
        IOptions<OpenWeatherMapOptions> options,
        ILogger<WeatherService> logger)
    {
        _httpClientFactory = httpClientFactory;
        _deserializerFactory = deserializerFactory;
        _options = options.Value;
        _logger = logger;
    }

    public async Task<WeatherInfo> GetWeatherAsync(string city, string format)
    {
        var deserializer = _deserializerFactory.GetDeserializer(format);

        string url = $"{_options.BaseUrl}?q={city}&mode={format}&units=metric&appid={_options.ApiKey}";

        try
        {
            var client = _httpClientFactory.CreateClient();
            using var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(10));
            string content = await client.GetStringAsync(url, cts.Token);

            WeatherInfo weather = await deserializer.DeserializeAsync(content);
            _logger.LogInformation("Weather data fetched successfully for {City} ({Format})", city, format);
            return weather;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to fetch weather for {City} ({Format})", city, format);
            return null;
        }
    }


    public async Task<string> GetWeatherAsyncRaw(string city, string format)
    {
        string url = $"{_options.BaseUrl}?q={city}&mode={format}&units=metric&appid={_options.ApiKey}";

        try
        {
            var client = _httpClientFactory.CreateClient();
            using var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(10));

            string content = await client.GetStringAsync(url, cts.Token);

            _logger.LogInformation("Raw weather data fetched successfully for {City} ({Format})", city, format);

            return content;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to fetch raw weather for {City} ({Format})", city, format);
            return null;
        }
    }

}