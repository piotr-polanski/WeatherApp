using System.Web.Http;
using WeatherApp.Domain;
using WeatherApp.WebApi.Models;

namespace WeatherApp.WebApi.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        [HttpGet]
        [Route("api/{country}/{city}")]
        public WeatherModel Get(string country, string city)
        {
            return new WeatherModel()
            {
                Humidity = 88
            };
        }
    }
}
