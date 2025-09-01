using System.Threading.Tasks;
using SimpleWeatherApp.Core.Models;

namespace SimpleWeatherApp.Core.Services
{
    public interface IWeatherService
    {
        /// <summary>
        /// Fetches and deserializes weather data into WeatherInfo.
        /// </summary>
        /// <param name="city">City name</param>
        /// <param name="format">Data format: "json" or "xml"</param>
        Task<WeatherInfo> GetWeatherAsync(string city, string format);

        /// <summary>
        /// Fetches the raw weather data as a string without deserialization.
        /// </summary>
        /// <param name="city">City name</param>
        /// <param name="format">Data format: "json" or "xml"</param>
        Task<string> GetWeatherAsyncRaw(string city, string format);
    }
}