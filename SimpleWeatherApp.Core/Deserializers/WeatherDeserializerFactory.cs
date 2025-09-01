using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleWeatherApp.Core.Deserializers
{
    using Microsoft.Extensions.DependencyInjection;

    public class WeatherDeserializerFactory(IServiceProvider provider) : IWeatherDeserializerFactory
    {
        private readonly IServiceProvider _provider = provider;

        public IWeatherDeserializer GetDeserializer(string format)
        {
            return format.ToLower() switch
            {
                "xml" => _provider.GetRequiredService<XmlWeatherDeserializer>(),
                "json" => _provider.GetRequiredService<JsonWeatherDeserializer>(),
                _ => throw new ArgumentException("Unsupported format")
            };
        }
    }

}
