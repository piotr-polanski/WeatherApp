namespace WeatherApp.Domain.ExternalWeatherService
{
    public class OpenWeatherMapService : IExternalWeatherService
    {
        public Weather GetCurrentWeather(string country, string city)
        {
            return new Weather()
            {
                Temperature = new Temperature()
                {
                    Format = "Celcius",
                    Value = 16
                },
                Humidity = 88
            };
        }
    }
}