using System.Reflection;
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
            container.Register(() =>
                {
                    var dbContext = new TestDbContext();
                    return dbContext;
                }, Lifestyle.Singleton
            );
            container.Register<ICustomerRepository, CustomerRepository>(lifestyle: Lifestyle.Transient);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));


        }
    }
}