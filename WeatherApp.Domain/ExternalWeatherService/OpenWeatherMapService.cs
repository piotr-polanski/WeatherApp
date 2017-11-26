namespace WeatherApp.Domain.ExternalWeatherService
{
    public class OpenWeatherMapService : IExternalWeatherService
    {
        public Weather GetCurrentWeather(string country, string city)
        {
            return new Weather(new Temperature("Celcius", 16), 88);
        }
    }
}