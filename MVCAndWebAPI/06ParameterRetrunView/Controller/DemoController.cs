using System;
using Microsoft.AspNetCore.Mvc;

namespace _06ParameterRetrunView
{
    public class DemoController : Controller
    {
        public ActionResult GetInfo([FromQuery] string mode)
        {
            if ("preview".Equals(mode, StringComparison.InvariantCultureIgnoreCase))
            {
                return View("PreView");
            }
            if ("pageview".Equals(mode, StringComparison.InvariantCultureIgnoreCase))
            {
                return View("pageview");
            }
            return View("~/Views/Default.cshtml");
        }
    }
}