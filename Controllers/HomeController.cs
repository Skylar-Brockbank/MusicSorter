using Microsoft.AspNetCore.Mvc;

namespace MusicSorter.Controllers
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