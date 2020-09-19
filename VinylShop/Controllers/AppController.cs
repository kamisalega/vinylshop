using Microsoft.AspNetCore.Mvc;

namespace VinylShop.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Skontaktuj się z nami";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "O nas";
            return View();
        }
    }
}
