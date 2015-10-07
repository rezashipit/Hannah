using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Chaos.Web.Dependency;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;

namespace Chaos.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IWindsorContainer container)
        {

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            var jsonFormater = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormater.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "Student", id = RouteParameter.Optional }
            );
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                new WindsorCompositionRoot(container));

        }
    }
}
