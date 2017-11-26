using AutoMapper;

namespace WeatherApp.Web.Mappers
{
    public class DefaultMapper : ICustomMapper
    {
        public TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }
    }
}