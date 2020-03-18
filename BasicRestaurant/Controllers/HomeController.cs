using Microsoft.AspNetCore.Mvc;

namespace BasicRestaurant.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}