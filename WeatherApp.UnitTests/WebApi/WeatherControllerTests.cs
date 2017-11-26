using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using NSubstitute;
using Shouldly;
using WeatherApp.Domain;
using WeatherApp.WebApi.Controllers;
using WeatherApp.WebApi.Mappers;
using WeatherApp.WebApi.Models;
using Xunit;

namespace WeatherApp.UnitTests.WebApi
{
    public class WeatherControllerTests
    {
        [Fact]
        public void Get_Given_CountryAndCity_Returns_WeatherModelFromMapper()
        {
            //arrange
            var weatherFromService = new Weather(
                new Temperature("", 0), 0);
            var weatherService = Substitute.For<IWeatherService>();
            weatherService.GetWeather(Arg.Any<string>(), Arg.Any<string>())
                .Returns(weatherFromService);

            WeatherModel resultFromMapper = new WeatherModel();
            var mapper = Substitute.For<ICustomMapper>();
            mapper.Map<WeatherModel>(weatherFromService).Returns(resultFromMapper);

            var sut = new WeatherController(weatherService, mapper)
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            //act
            var result = sut.Get(Arg.Any<string>(), Arg.Any<string>());

            //assert
            result.ShouldBe(resultFromMapper);
        }
    }
}
