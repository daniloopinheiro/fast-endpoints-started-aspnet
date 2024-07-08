using FastEndpoints;
using FastEndpoints.Swagger;

namespace FESAspNet.API;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        // Add services to the FastEndpoints.
        builder.Services
            .AddFastEndpoints()
            .SwaggerDocument();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}

        //app.UseHttpsRedirection();

        app.UseFastEndpoints()
           .UseSwaggerGen();
        app.Run();
    }
}