namespace WeatherApp.Domain
{
    public class Temperature
    {
        public Temperature(string format, int value)
        {
            Format = format;
            Value = value;
        }

        public string Format { get; }
        public int Value { get; }
    }
}