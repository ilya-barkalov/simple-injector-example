using MobileProvider.Models;
using System.Web.Mvc;

namespace MobileProvider.Controllers
{
  public class HomeController : Controller
  {
    private readonly IProvider provider;

    //inject dependency 
    public HomeController(IProvider provider)
    {
      this.provider = provider;
    }

    public ActionResult Index()
    {
      ViewBag.Message = provider.MessageFromProvider();
        
      return View();
    }
  }
}