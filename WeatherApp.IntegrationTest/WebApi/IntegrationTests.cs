using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using NSubstitute;
using Shouldly;
using WeatherApp.Domain;
using WeatherApp.Domain.ExternalWeatherService;
using WeatherApp.WebApi.Controllers;
using WeatherApp.WebApi.Mappers;
using Xunit;

namespace WeatherApp.IntegrationTest.WebApi
{
    public class IntegrationTests
    {
        [Fact]
        public void Get_Given_AnyCountryAndCity_Returns_WeatherModel()
        {
            //arrange
			Mapper.Initialize(Mappings.CreateMappings);

			var dummyExternalWeatherService = new DummyWeatherService();
			var weatherService = new WeatherService(dummyExternalWeatherService);
            var sut = new WeatherController(weatherService, new DefaultMapper())
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var dummyWeather = dummyExternalWeatherService.GetCurrentWeather(Arg.Any<string>(), Arg.Any<string>());

            //act
            var weatherModel = sut.Get(Arg.Any<string>(), Arg.Any<string>());

            //assert
			//DummyWeatherService always returns the same weather
			weatherModel.Temperature.Value.ShouldBe(dummyWeather.Temperature.Value);
			weatherModel.Temperature.Format.ShouldBe(dummyWeather.Temperature.Format);
			weatherModel.Humidity.ShouldBe(dummyWeather.Humidity);
        }
    }
}
