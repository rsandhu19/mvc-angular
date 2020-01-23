using System.Web.Http;
using System.Web.Mvc;
using EmployeeManagementSystem.DataRepository;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using Unity;
using Unity.Mvc5;

namespace EmployeeManagementSystem
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = BuildUnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // you don't need to register controllers
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEmployeeService, EmployeeService>();


            return container;
        }
    }
}