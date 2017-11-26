using NSubstitute;
using Shouldly;
using WeatherApp.Domain.ExternalWeatherService;
using Xunit;

namespace WeatherApp.UnitTests.Domain.ExternalWeatherService
{
    public class DummyWeatherServiceTests
    {
        [Fact]
        public void GetCurrentWeather_Given_AnyCountryAndCity_Returns_DummyWeather()
        {
            //arrange
            var sut = new DummyWeatherService();

            //act
            var dummyWeather = sut.GetCurrentWeather(Arg.Any<string>(), Arg.Any<string>());

            //assert
            //DummyWeatherService always returns the same Weather
            dummyWeather.Temperature.Format.ShouldBe("Celcius");
            dummyWeather.Temperature.Value.ShouldBe(16);
            dummyWeather.Humidity.ShouldBe(88);
        }
    }
}
