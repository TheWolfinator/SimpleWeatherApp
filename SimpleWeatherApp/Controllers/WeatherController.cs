using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleWeatherApp.Core.Services;
using System.Threading.Tasks;

namespace SimpleWeatherApp.Controllers
{
    [Route("weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(IWeatherService weatherService, ILogger<WeatherController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        // Usage: /weather?city=Manila&format=json
        [HttpGet("")]
        public async Task<IActionResult> GetWeather([FromQuery] string city, [FromQuery] string format = "json")
        {
            var rawContent = await _weatherService.GetWeatherAsyncRaw(city, format);

            if (string.IsNullOrEmpty(rawContent))
            {
                _logger.LogWarning("No raw data returned for {City} ({Format})", city, format);
                return StatusCode(500, "Failed to fetch weather data");
            }

            string contentType = format.ToLower() == "xml" ? "application/xml" : "application/json";
            return Content(rawContent, contentType);
        }
    }
}
