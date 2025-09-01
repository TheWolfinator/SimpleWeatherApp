using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;

[XmlRoot("current")]
public class WeatherInfo
{
    // -----------------------
    // City
    // -----------------------
    [XmlElement("city")]
    [JsonIgnore]
    public City City { get; set; }

    [XmlIgnore]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    // -----------------------
    // Main (JSON)
    // -----------------------
    [JsonPropertyName("main")]
    [XmlIgnore]
    public MainJson MainJson { get; set; }

    // -----------------------
    // XML Temperature / FeelsLike / Humidity / Pressure
    // -----------------------
    [XmlElement("temperature")]
    [JsonIgnore]
    public TemperatureXml TemperatureXml { get; set; }

    [XmlElement("feels_like")]
    [JsonIgnore]
    public FeelsLike FeelsLikeXml { get; set; }

    [XmlElement("humidity")]
    [JsonIgnore]
    public Humidity HumidityXml { get; set; }

    [XmlElement("pressure")]
    [JsonIgnore]
    public Pressure PressureXml { get; set; }

    // -----------------------
    // Wind
    // -----------------------
    [XmlElement("wind")]
    [JsonIgnore]
    public WindXml WindXml { get; set; }

    [JsonPropertyName("wind")]
    [XmlIgnore]
    public WindJson WindJson { get; set; }

    // -----------------------
    // Clouds
    // -----------------------
    [XmlElement("clouds")]
    [JsonPropertyName("clouds")]
    public Clouds Clouds { get; set; }

    // -----------------------
    // Visibility
    // -----------------------
    [XmlElement("visibility")]
    [JsonIgnore]
    public Visibility VisibilityXml { get; set; }

    [JsonPropertyName("visibility")]
    [XmlIgnore]
    public int? VisibilityJson { get; set; }

    // -----------------------
    // Precipitation (optional, XML only)
    // -----------------------
    [XmlElement("precipitation")]
    public Precipitation Precipitation { get; set; }

    // -----------------------
    // Weather conditions
    // -----------------------
    [XmlElement("weather")]
    [JsonPropertyName("weather")]
    public List<Weather> Weather { get; set; }

    // -----------------------
    // Last update / timestamp
    // -----------------------
    [XmlElement("lastupdate")]
    [JsonIgnore]
    public LastUpdate LastUpdateXml { get; set; }

    [JsonPropertyName("dt")]
    [XmlIgnore]
    public long? DtJson { get; set; }

    // -----------------------
    // Helper methods to read unified values
    // -----------------------
    [XmlIgnore]
    [JsonIgnore]
    public double Temperature => TemperatureXml?.Value ?? MainJson?.Temp ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public double FeelsLikeValue => FeelsLikeXml?.Value ?? MainJson?.FeelsLike ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public int PressureValue => PressureXml?.Value ?? MainJson?.Pressure ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public int HumidityValue => HumidityXml?.Value ?? MainJson?.Humidity ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public int VisibilityValue => VisibilityXml?.Value ?? VisibilityJson ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public double WindSpeed => WindXml?.Speed?.Value ?? WindJson?.Speed ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public double WindGust => WindXml?.Gust?.Value ?? WindJson?.Gust ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public int WindDeg => WindXml?.Direction?.Value ?? WindJson?.Deg ?? 0;

    [XmlIgnore]
    [JsonIgnore]
    public DateTime LastUpdate => LastUpdateXml?.Value ?? DateTimeOffset.FromUnixTimeSeconds(DtJson ?? 0).UtcDateTime;
}