
# SimpleWeatherApp

A simple ASP.NET Core MVC application that fetches weather data from OpenWeatherMap API.

> **Note:** Currently, the API returns raw responses or deserialized JSON directly from the service. HTML view rendering is planned for future implementation.

---

## Features

* Fetch weather data in **JSON** or **XML** format.
* View **raw API responses**.
* Deserialized weather info is available via the service (no controller/view yet; HTML rendering planned for future).
---

## Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* OpenWeatherMap API Key ([https://openweathermap.org/api](https://openweathermap.org/api))
* Visual Studio 2022 / VS Code or any compatible IDE

---

## Getting Started

1. **Clone the repository**

```bash
git clone https://github.com/<YOUR_GITHUB_USERNAME>/SimpleWeatherApp.git
cd SimpleWeatherApp
```

2. **Set your API key**

Open `appsettings.json` and replace the placeholder with your OpenWeatherMap API key:

```json
{
  "WeatherApiOptions": {
    "ApiKey": "<YOUR API KEY HERE>"
  }
}
```

3. **Restore packages**

```bash
dotnet restore
```
4. **Run the application**
```bash
dotnet run
```
By default, the application will run at:
```
https://localhost:7152
http://localhost:5000
```
---

## Usage

### 1. Deserialized Weather (via Service)

You can call the service directly in your code:

```csharp
var weather = await weatherService.GetWeatherAsync("Manila", "json");
```

> Currently, no controller returns the deserialized object. HTML view rendering is planned for future implementation.

### 2. Raw API Responses

You can access raw API responses through the existing controller:

* JSON: `/weather?city=Manila&format=json`
* XML: `/weather?city=Manila&format=xml`


# Notes

* Strategy pattern selects the appropriate deserializer for JSON or XML.
* `HttpClientFactory` is used for efficient HTTP requests.
* Logging via `ILogger` tracks API calls and errors.
* HTML view rendering is planned for future implementation; currently, deserialized data is only available in the service layer.

---

## License

This project is licensed under the MIT License.
