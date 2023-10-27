namespace SimpleUI.DataAccess;
using Refit;
using SimpleUI.Models;

public interface IWeatherData
{
    [Get("/WeatherForecast")]
    Task<List<WeatherModel>> GetWeather();
}
