﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Chaos.Web.Dependency
{
        public class ControllerInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                container.Register(

                    //All MVC controllers
                    Classes.FromThisAssembly().BasedOn<ApiController>().LifestyleTransient()

                    );
            }
        }

    
}