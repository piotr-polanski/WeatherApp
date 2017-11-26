using System.Web.Http;
using AutoMapper;
using WeatherApp.Domain;
using WeatherApp.WebApi.Mappers;
using WeatherApp.WebApi.Models;

namespace WeatherApp.WebApi.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly IWeatherService _weatherService;
        private readonly ICustomMapper _mapper;

        public WeatherController(IWeatherService weatherService, ICustomMapper mapper)
        {
            _weatherService = weatherService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("api/{country}/{city}")]
        public WeatherModel Get(string country, string city)
        {
            return _mapper.Map<WeatherModel>(_weatherService.GetWeather(country, city));
        }
    }
}
