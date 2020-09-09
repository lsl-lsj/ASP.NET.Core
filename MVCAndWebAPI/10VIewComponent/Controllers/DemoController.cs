using Microsoft.AspNetCore.Mvc;

namespace _10VIewComponent.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}