using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Humidity
{
    [XmlAttribute("value")]
    public int Value { get; set; }

    [XmlAttribute("unit")]
    public string Unit { get; set; }
}