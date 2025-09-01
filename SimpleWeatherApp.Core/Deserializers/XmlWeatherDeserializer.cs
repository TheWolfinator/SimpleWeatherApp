using SimpleWeatherApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWeatherApp.Core.Deserializers
{
    public class XmlWeatherDeserializer : IWeatherDeserializer
    {
        public Task<WeatherInfo> DeserializeAsync(string content)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeatherInfo));
            using var reader = new System.IO.StringReader(content);
            WeatherInfo weather = (WeatherInfo)serializer.Deserialize(reader);
            return Task.FromResult(weather);
        }
    }
}
