using Microsoft.AspNetCore.Mvc;

namespace _07UseLayoutPage
{
    public class DemoController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }
    }
}