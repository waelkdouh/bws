using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherClientLib;
using GeolocationService = AspNetMonsters.Blazor.Geolocation.LocationService;

namespace BlazorWeather
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IWeatherForecastService, HttpWeatherForecastService>();
            builder.Services.AddScoped<GeolocationService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<PinnedLocationsService>();
            builder.Services.AddScoped<IConfiguration, LocalStorageConfiguration>();

            await builder.Build().RunAsync();
        }
    }
}
