using SimpleInjector;
using MobileProvider.Models;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;

namespace MobileProvider.App_Start
{
  public class SimpleInjectorConfig
  {
    public static void RegisterComponents()
    {
      var container = new Container();
      // register all your components with the container here 
      // it is NOT necessary to register your controllers 

      container.Register<IProvider, TELE2>();

      //DependencyResolver.SetResolver(new UnityDependencyResolver(container)); 
      container.Verify();

      DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
    }
  }
}