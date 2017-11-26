using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using WeatherApp.Domain;
using WeatherApp.Domain.ExternalWeatherService;
using WeatherApp.WebApi.Mappers;
using WeatherApp.WebApi.Models;

namespace WeatherApp.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Mapper.Initialize(cfg => {
                cfg.CreateMap<Weather, WeatherModel>();
            });


            var builder = new ContainerBuilder();

            builder.RegisterType<WeatherService>().As<IWeatherService>();
            builder.RegisterType<OpenWeatherMapService>().As<IExternalWeatherService>();
            builder.RegisterType<DefaultMapper>().As<ICustomMapper>();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
