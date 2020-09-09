using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace _10VIewComponent
{
    public class TestViewComponent : ViewComponent
    {
        private readonly IWebHostEnvironment _env;
        public TestViewComponent(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IViewComponentResult Invoke()
        {
            return View("_showInfo", _env);
        }
    }
}