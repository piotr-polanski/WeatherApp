using AutoMapper;
using WeatherApp.Domain;
using WeatherApp.WebApi.Models;

namespace WeatherApp.WebApi.Mappers
{
    public class Mappings
    {
        public static void CreateMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Weather, WeatherModel>();
        }
    }
}