namespace WeatherApp.WebApi.Models
{
    public class WeatherModel
    {
        public TemperatureModel Temperature { get; set; }
        public int Humidity { get; set; }
    }
}