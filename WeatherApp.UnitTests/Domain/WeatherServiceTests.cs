using NSubstitute;
using Shouldly;
using WeatherApp.Domain;
using WeatherApp.Domain.ExternalWeatherService;
using Xunit;

namespace WeatherApp.UnitTests.Domain
{
    public class WeatherServiceTests
    {
        [Fact]
        public void GetWeather_Given_LondonAndUk_Returns_WeatherFromExternalWeatherService()
        {
            //arrange
            var externalWeatherService = Substitute.For<IExternalWeatherService>();
            var weatherInLondon = new Weather(new Temperature("Celcius", 16), 88);

            externalWeatherService.GetCurrentWeather("UK", "London").Returns(weatherInLondon);
            var sut = new WeatherService(externalWeatherService);

            //act
            var weather = sut.GetWeather("UK", "London");

            //assert
            weather.Temperature.Format.ShouldBe(weatherInLondon.Temperature.Format);
            weather.Temperature.Value.ShouldBe(weatherInLondon.Temperature.Value);
            weather.Humidity.ShouldBe(weatherInLondon.Humidity);
        }

    }
}
