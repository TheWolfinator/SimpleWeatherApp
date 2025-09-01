using SimpleWeatherApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWeatherApp.Core.Deserializers
{
    public interface IWeatherDeserializer
    {
        Task<WeatherInfo> DeserializeAsync(string content);
    }
}
