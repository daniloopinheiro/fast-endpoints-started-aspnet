namespace FESAspNet.API.Requests;

public class WeatherRequest
{
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }

    public WeatherRequest()
    {
        
    }
}