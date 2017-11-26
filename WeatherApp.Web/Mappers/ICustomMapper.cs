namespace WeatherApp.Web.Mappers
{
    public interface ICustomMapper
    {
        TDestination Map<TDestination>(object source);
    }
}
