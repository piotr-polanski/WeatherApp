using Autofac;
using WeatherApp.Domain;
using WeatherApp.Domain.ExternalWeatherService;
using WeatherApp.Web.Mappers;

namespace WeatherApp.Web.IoC
{
    public class IoCRegistration
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<WeatherService>().As<IWeatherService>();
            builder.RegisterType<DummyWeatherService>().As<IExternalWeatherService>();
            builder.RegisterType<DefaultMapper>().As<ICustomMapper>();
        }
    }
}