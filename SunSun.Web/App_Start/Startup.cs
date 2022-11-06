using Microsoft.Owin;
using Owin;
using Autofac;
using System;
using System.Threading.Tasks;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using SunSun.Data.Infrastructure;
using SunSun.Data;
using SunSun.Data.Repositories;
using SunSun.Service;
using System.Web.Mvc;
using System.Web.Http;
using SunSun.Model.Models;

[assembly: OwinStartup(typeof(SunSun.Web.App_Start.Startup))]

namespace SunSun.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }
        private void ConfigAutofac(IAppBuilder app)
        {
            var buider = new ContainerBuilder();
            //Controller
            buider.RegisterControllers(Assembly.GetExecutingAssembly());
            //Api Controller
            buider.RegisterApiControllers(Assembly.GetExecutingAssembly());

            buider.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            buider.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            buider.RegisterType<SunSunShopDBContext>().AsSelf().InstancePerRequest();

            //Repositories
            buider.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //Services
            buider.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = buider.Build();
            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
