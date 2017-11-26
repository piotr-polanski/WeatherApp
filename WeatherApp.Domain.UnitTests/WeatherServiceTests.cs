using NSubstitute;
using Shouldly;
using WeatherApp.Domain.ExternalWeatherService;
using Xunit;

namespace WeatherApp.Domain.UnitTests
{
    public class WeatherServiceTests
    {
        [Fact]
        public void GetWeather_Given_LondonAndUk_Returns_WeatherForThisCityAndCountry()
        {
            //arrange
            var externalWeatherService = Substitute.For<IExternalWeatherService>();
            var weatherInLondon = new Weather()
            {
                Temperature = new Temperature()
                {
                    Format = "Celcius",
                    Value = 16
                },
                Humidity = 88
            };
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
