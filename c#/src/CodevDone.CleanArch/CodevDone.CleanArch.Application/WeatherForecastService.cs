using CodevDone.CleanArch.CoreDomain;

namespace CodevDone.CleanArch.Application;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _repo;
    public WeatherForecastService(IWeatherForecastRepository repo)
    {
        _repo = repo;
    }

    public List<WeatherForecast> ProcessFTemperature()
    {
        var forecast = _repo.GetForecaste();
        var processed = new List<WeatherForecast>();

        foreach (var f in forecast)
        {
            f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
            processed.Add(f);
        }

        return processed;

    }

}
