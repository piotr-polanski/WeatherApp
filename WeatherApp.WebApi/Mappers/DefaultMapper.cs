using AutoMapper;

namespace WeatherApp.WebApi.Mappers
{
    public class DefaultMapper : ICustomMapper
    {
        public TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }
    }
}