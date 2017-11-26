namespace WeatherApp.WebApi.Mappers
{
    public interface ICustomMapper
    {
        TDestination Map<TDestination>(object source);
    }
}
