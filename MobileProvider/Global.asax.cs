using System.Web.Routing;
using System.Web.Mvc;
using MobileProvider.App_Start;

namespace MobileProvider
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      SimpleInjectorConfig.RegisterComponents();
      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
  }
}
