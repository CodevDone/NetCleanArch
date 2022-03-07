using CodevDone.CleanArch.CoreDomain;

namespace CodevDone.CleanArch.Application;

public interface IWeatherForecastService
{
    List<WeatherForecast> ProcessFTemperature();
}

