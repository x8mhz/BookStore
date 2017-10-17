using BookStore.Application.AppServices;
using BookStore.Application.AppServices.Interfaces;
using Microsoft.Practices.Unity;

namespace BookStore.Web
{
    public class IocConfigurator
    {
        public static void ConfigureIocContainer()
        {
            IUnityContainer container = new UnityContainer();

            RegisterServices(container);

            //DependencyResolver.SetResolver(new BookStoreDependencyResolver(container));
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IUserAppService, UserAppService>();
        }
    }
}