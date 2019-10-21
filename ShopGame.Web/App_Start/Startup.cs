using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using ShopGame.Data.intefacestruct;
using ShopGame.Data;
using Autofac.Integration.WebApi;
using System.Reflection;
using ShopGame.Data.Repositories;
using ShopGame.Service;
using System.Web.Mvc;
using System.Web.Http;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using System.Web;
using ShopGame.Model.Models;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(ShopGame.Web.App_Start.Startup))]

namespace ShopGame.Web.App_Start
{
    public  partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
            ConfigureAuth(app);
        }
        public void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterFilterProvider();

            builder.RegisterType<DbModelContext>().AsSelf().InstancePerRequest();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //Asp.net Identity
            builder.RegisterType<ApplicationStore>().As<IUserStore<ApplicationUser>>().InstancePerRequest();
            builder.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();
            builder.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
            builder.Register<IAuthenticationManager>(c=>HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register<IDataProtectionProvider>(c=>app.GetDataProtectionProvider()).InstancePerRequest();

            //repository
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            //Service
            builder.RegisterAssemblyTypes(typeof(IPostCateGoryService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();
               
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container); //set the web api DependencyResolver


        }
    }
}
