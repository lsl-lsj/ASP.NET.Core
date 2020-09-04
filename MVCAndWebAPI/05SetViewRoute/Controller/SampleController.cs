using Microsoft.AspNetCore.Mvc;

namespace _05SetViewRoute
{
    [Route("[Controller]/[action]")]
    public class SampleController : Controller 
    {
        public ActionResult Test1 => View();
        public ActionResult Test2 => View();
    }
}