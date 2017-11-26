namespace WeatherApp.Domain.ExternalWeatherService
{
    public interface IExternalWeatherService
    {
        Weather GetCurrentWeather(string country, string city);
    }
}