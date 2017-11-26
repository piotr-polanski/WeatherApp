using WeatherApp.Domain.ExternalWeatherService;

namespace WeatherApp.Domain
{
    public class WeatherService : IWeatherService
    {
        private readonly IExternalWeatherService _externalWeatherService;

        public WeatherService(IExternalWeatherService externalWeatherService)
        {
            _externalWeatherService = externalWeatherService;
        }

        public Weather GetWeather(string country, string city)
        {
            return _externalWeatherService.GetCurrentWeather(country, city);
        }
    }
}
