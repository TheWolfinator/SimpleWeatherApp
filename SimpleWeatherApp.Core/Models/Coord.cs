using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Coord
{
    [XmlAttribute("lon")]
    [JsonPropertyName("lon")]
    public double Lon { get; set; }

    [XmlAttribute("lat")]
    [JsonPropertyName("lat")]
    public double Lat { get; set; }
}