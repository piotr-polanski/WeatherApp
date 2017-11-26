namespace WeatherApp.Domain
{
    public interface IWeatherService
    {
        Weather GetWeather(string country, string city);
    }
}