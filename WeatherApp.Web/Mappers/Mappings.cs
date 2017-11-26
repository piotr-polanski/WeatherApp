using AutoMapper;
using WeatherApp.Domain;
using WeatherApp.Web.Models;

namespace WeatherApp.Web.Mappers
{
    public class Mappings
    {
        public static void CreateMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Weather, WeatherModel>();
        }
    }
}