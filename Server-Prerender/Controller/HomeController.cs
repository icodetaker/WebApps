using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace Prerending.HomeController {
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Chart([FromServices] INodeServices nodeServices)
        {
            ViewData["ResultFromNode"] = await nodeServices.InvokeAsync<string>("ChartModule.js");
            return View();
        }

        
    }
}