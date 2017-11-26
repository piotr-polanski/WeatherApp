using NSubstitute;
using Shouldly;
using WeatherApp.Domain.ExternalWeatherService;
using Xunit;

namespace WeatherApp.Domain.UnitTests.ExternalWeatherService
{
    public class OpenWeatherMapServiceTests
    {
        [Fact]
        public void GetCurrentWeather_Given_AnyCountryAndCity_Returns_DummyWeather()
        {
            //arrange
            var sut = new OpenWeatherMapService();

            //act
            var dummyWeather = sut.GetCurrentWeather(Arg.Any<string>(), Arg.Any<string>());

            //assert
            dummyWeather.Temperature.Format.ShouldBe("Celcius");
            dummyWeather.Temperature.Value.ShouldBe(16);
            dummyWeather.Humidity.ShouldBe(88);
        }
    }
}
