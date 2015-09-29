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
            InitilizeWindsor();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
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
        private void InitilizeWindsor()
        {
            _windContainer = new WindsorContainer();
            _windContainer.Install(FromAssembly.Containing<DependencyInstaller>());
            _windContainer.Install(FromAssembly.This());

            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windContainer.Kernel));
        }
    }
}
