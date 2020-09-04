using Microsoft.AspNetCore.Mvc;

namespace _04MVCRoute
{
    public class DemoController : Controller
    {
        public ActionResult Default()
        {
            return Ok("这是一个Web应用");
        }
    }
}