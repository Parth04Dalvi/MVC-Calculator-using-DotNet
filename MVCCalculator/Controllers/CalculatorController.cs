using Microsoft.AspNetCore.Mvc;
using MVCCalculator.Models;

namespace MVCCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            model.Calculate();
            return View(model);
        }
    }
}
