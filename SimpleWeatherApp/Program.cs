using SimpleWeatherApp;
using SimpleWeatherApp.Core.Deserializers;
using SimpleWeatherApp.Core.Options;
using SimpleWeatherApp.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.Configure<OpenWeatherMapOptions>(builder.Configuration.GetSection("OpenWeatherMap"));
builder.Services.AddTransient<XmlWeatherDeserializer>();
builder.Services.AddTransient<JsonWeatherDeserializer>();
builder.Services.AddSingleton<IWeatherDeserializerFactory, WeatherDeserializerFactory>();

builder.Services.AddTransient<IWeatherService, WeatherService>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
