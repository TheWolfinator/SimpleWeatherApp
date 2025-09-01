using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Clouds
{
    [XmlAttribute("value")]
    [JsonPropertyName("all")]
    public int Value { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }
}