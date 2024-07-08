namespace FESAspNet.API.Responses;

public class WeatherResponse
{
    public WeatherResponse(DateOnly endDate, int temperatureF, string[]? summary)
    {
        EndDate = endDate;
        TemperatureF = temperatureF;
        Summary = summary;
    }

    public WeatherResponse()
    {
        
    }

    public DateOnly EndDate { get; set; }
    public int TemperatureF { get; set; }
    public string[]? Summary { get; set; }
}
