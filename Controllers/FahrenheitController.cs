using MetricSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MetricSystem.Controllers
{
    public class FahrenheitController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new MetricSystemModel());
        }

        [HttpPost]
        public IActionResult Index(MetricSystemModel model)
        {
            if (ModelState.IsValid)
            {
                model.ConvertToCelsius();
            }
            return View(model);
        }
    }
}
