using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

using ShopGame.Data.intefacestruct;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using ShopGame.Data;
using ShopGame.Data.Repositories;
using ShopGame.Service;
using System.Web.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(ShopGame.Web.App_Start.Startup))]

namespace ShopGame.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }
        public void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();


            builder.RegisterType<DbModelContext>().AsSelf().InstancePerRequest();

            //repository
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            //Service
            builder.RegisterAssemblyTypes(typeof(IPostCateGoryService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //set the web api DependencyResolver


        }
    }
}
