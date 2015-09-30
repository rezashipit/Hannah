using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using eLearning.Dependency;
using eLearning.Web.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace eLearning.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private WindsorContainer _windContainer;
        protected void Application_Start()
        {
            InitilizeWindsor(GlobalConfiguration.Configuration);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(c => WebApiConfig.Register(c, _windContainer));
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_End()
        {
            if (_windContainer != null)
            {
                _windContainer.Dispose();
            }
        }
        private void InitilizeWindsor(HttpConfiguration configuration)
        {
            _windContainer = new WindsorContainer();
            _windContainer.Install(FromAssembly.This());
            _windContainer.Kernel.Resolver.AddSubResolver(
                new CollectionResolver(_windContainer.Kernel,true));
            var dependencyResolver=new WindsorDependencyResolver(_windContainer);
            configuration.DependencyResolver=dependencyResolver;

            _windContainer.Install(FromAssembly.Containing<DependencyInstaller>());

            //ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windContainer.Kernel));
            //ApiControllerBuilder
        }
    }
}
