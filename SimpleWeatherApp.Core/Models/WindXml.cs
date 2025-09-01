using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class WindXml
{
    [XmlElement("speed")]
    public Speed Speed { get; set; }

    [XmlElement("gusts")]
    public Gust Gust { get; set; }

    [XmlElement("direction")]
    public Direction Direction { get; set; }
}