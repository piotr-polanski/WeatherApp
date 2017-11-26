using System.Web.Mvc;
using WeatherApp.Domain;
using WeatherApp.Web.Mappers;
using WeatherApp.Web.Models;

namespace WeatherApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;
        private readonly ICustomMapper _mapper;

        public HomeController(IWeatherService weatherService, ICustomMapper mapper)
        {
            _weatherService = weatherService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowWeather(WeatherQuestion weatherQuestion)
        {
            var weather = _weatherService.GetWeather(weatherQuestion.Country, weatherQuestion.City);
            var weatherModel = _mapper.Map<WeatherModel>(weather);
            return View(weatherModel);
        }
    }

}