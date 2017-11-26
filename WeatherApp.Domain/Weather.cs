namespace WeatherApp.Domain
{
    public class Weather
    {
        public Temperature Temperature { get; set; }
        public int Humidity { get; set; }
    }

    public class Temperature
    {
        public string Format { get; set; }
        public int Value { get; set; }
    }
}