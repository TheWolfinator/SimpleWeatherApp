using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Weather
{
    [XmlAttribute("number")]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [XmlAttribute("value")]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [XmlAttribute("icon")]
    [JsonPropertyName("icon")]
    public string Icon { get; set; }
}