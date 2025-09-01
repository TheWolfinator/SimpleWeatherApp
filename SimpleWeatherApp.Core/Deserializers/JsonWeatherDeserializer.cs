using SimpleWeatherApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWeatherApp.Core.Deserializers
{
    public class JsonWeatherDeserializer : IWeatherDeserializer
    {
        public Task<WeatherInfo> DeserializeAsync(string content)
        {
            WeatherInfo weather = System.Text.Json.JsonSerializer.Deserialize<WeatherInfo>(content);
            return Task.FromResult(weather);
        }
    }
}
