using FastEndpoints;
using FESAspNet.API.Requests;
using FESAspNet.API.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using System;

namespace FESAspNet.API.Endpoints.WeatherForecast.Post;

public class WeatherCreateEndpoint : Endpoint<WeatherRequest, WeatherResponse>
{
    public override void Configure()
    {
        Verbs(Http.POST);
        Routes("/weatherforecast/create");
        AllowAnonymous();
    }

    public override async Task<Task> HandleAsync(WeatherRequest request, CancellationToken ct)
    {
        await SendAsync(new()
        {
            EndDate = request.Date,
            TemperatureF = 32 + (int)(request.TemperatureC / 0.5556)
        });

        return Task.CompletedTask;
    }
}
