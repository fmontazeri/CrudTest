using System.Data.Entity;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using FmCrudTest.Data.Context;
using FmCrudTest.Data.Services;
using FmCrudTest.Domain.CustomerAgg;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace FmCrudTest.Presentation
{
    public static class Bootstraper
    {
        public static void Wireup(Container container)
        {
 
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //var hybridLifestyle = Lifestyle.CreateHybrid(()=> )
            //() => HttpContext.Current != null,
            //new WebRequestLifestyle(),
            //new LifetimeScopeLifestyle());

            // Register as hybrid PerWebRequest / PerLifetimeScope.
            //container.Register<DbContext, MyDbContext>(hybridLifestyle);

            container.Register(() =>
                {
                    var dbContext = new TestDbContext();
                    return dbContext;
                }, Lifestyle.Scoped
            );

            container.Register<ICustomerRepository, CustomerRepository>(lifestyle: Lifestyle.Transient);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));


        }
    }
}