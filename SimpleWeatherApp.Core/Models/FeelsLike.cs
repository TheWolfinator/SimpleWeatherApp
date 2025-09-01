using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class FeelsLike
{
    [XmlAttribute("value")]
    public double Value { get; set; }

    [XmlAttribute("unit")]
    public string Unit { get; set; }
}