using System.Collections.Generic;
using _07ServicesLifeCycle.TestClass;
using Microsoft.AspNetCore.Mvc;

namespace _07ServicesLifeCycle.Controllers
{
    [ApiController]
    [Route("")]
    public class DemoController : ControllerBase
    {
        private readonly ServiceA _serviceA;
        private readonly ServiceB _serviceB;
        private readonly ServiceC _serviceC;
        private readonly ServiceDependencyAll _serviceDep;

        public DemoController(ServiceA a, ServiceB b, ServiceC c, ServiceDependencyAll d)
        {
            _serviceA = a;
            _serviceB = b;
            _serviceC = c;
            _serviceDep = d;
        }

        [HttpGet]
        public IActionResult Check()
        {
            List<string> list = new List<string>();
            list.Add($"暂时服务：{_serviceA.ID}<br/>");
            list.Add($"作用域服务：{_serviceB.ID}");
            list.Add($"单一实例服务：{_serviceC.ID}");
            list.Add(string.Empty);
            list.Add("存在依赖关系的服务：");
            list.Add($"暂时服务：{_serviceDep.Service_A.ID}");
            list.Add($"作用域服务：{_serviceDep.Service_B.ID}");
            list.Add($"单一实例服务：{_serviceDep.Service_C.ID}");

            return Ok(list);
        }
    }
}