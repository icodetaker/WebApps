using Microsoft.AspNetCore.Mvc;

namespace Prerending.HomeController {
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}