namespace WeatherApp.Domain
{
    public class WeatherService : IWeatherService
    {
        public Weather GetWeather(string country, string city)
        {
            return new Weather();
        }
    }
}
