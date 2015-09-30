using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using eLearning.Web.Dependency;

namespace eLearning.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config,IWindsorContainer container)
        {
           
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {controller="Student", id = RouteParameter.Optional }
            );
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                new WindsorCompositionRoot(container));
         
        }
    }
}
