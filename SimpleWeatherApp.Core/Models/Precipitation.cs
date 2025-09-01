using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Precipitation
{
    [XmlAttribute("mode")]
    public string Mode { get; set; }
}