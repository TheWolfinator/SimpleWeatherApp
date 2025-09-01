using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Gust
{
    [XmlAttribute("value")]
    public double Value { get; set; }
}