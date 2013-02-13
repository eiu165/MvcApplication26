using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;   
using ClassLibrary1;
using Interceptor;

namespace CastleDemo.Installers
{
    public class StoryTellerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
  
            container.Register(
                Component.For<IStoryTeller>()
                         .ImplementedBy<DutchStoryTeller>()       //     FrenchStoryTeller
                         .Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere);

        }
    }
    public class PrintableInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IPrintable>().ImplementedBy<ConsolePrint>());
            //container.Register(Component.For<IStoryTeller>().ImplementedBy<FrenchStoryTeller>());
        }
    }
}