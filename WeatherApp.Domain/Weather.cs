namespace WeatherApp.Domain
{
    public class Weather
    {
        public Weather(Temperature temperature, int humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
        }

        public Temperature Temperature { get; }
        public int Humidity { get;  }
    }
}