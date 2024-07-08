using FastEndpoints;
using FESAspNet.API.Responses;
using System.Linq;
using Http = FastEndpoints.Http;

namespace FESAspNet.API.Endpoints.WeatherForecast.Get;

public class WeatherGet : EndpointWithoutRequest<WeatherResponse>
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/weatherforecast");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var resp = GetWeatherForecast();

        foreach(var item in resp) 
        {
            Console.WriteLine($"Date: {item.EndDate}, Temperature: {item.TemperatureF}, Summary: {item.Summary}");
        }
        await Task.CompletedTask;
    }

    public static WeatherResponse[] GetWeatherForecast()
    {
        var forecast = Enumerable.Range(1, 5).Select(index => 
            new WeatherResponse
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"]
            )
        ).ToArray();

        return forecast;
    }
}