using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace Prerending.HomeController
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Chart([FromServices] INodeServices nodeServices)
        {
            var options = new
            {
                width = 400,
                height = 200,
                showArea = true,
                showPoint = true,
                fullWidth = true
            };

            var data = new
            {
                labels = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" },
                series = new[] {
                    new[] { 1, 5, 2, 5, 4, 3},
                    new[] { 2, 3, 5, 8, 1, 2},
                    new[] { 5, 4, 3, 2, 1, 0}
                }
            };


            ViewData["ResultFromNode"] = await nodeServices.InvokeAsync<string>(
                "ChartModule.js",
                "line", options, data);
            return View();
        }


    }
}