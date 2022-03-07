using CodevDone.CleanArch.CoreDomain;

namespace CodevDone.CleanArch.Application;

public interface IWeatherForecastRepository
{
    WeatherForecast[] GetForecaste();
}
