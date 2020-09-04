using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace _10DefinitionMiddleWare
{
    public class SampleMiddleware
    {
        // 下一个中间件的引用
        private readonly RequestDelegate m_next;
        private readonly int _a, _b;
        public SampleMiddleware(RequestDelegate next)
        {
            m_next = next;
        }

        public SampleMiddleware(RequestDelegate next, int a, int b)
        {
            m_next = next;
            _a = a;
            _b = b;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (_a != 0 && _b != 0)
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync($"{_a} x {_b} = {_a * _b}<br/>");
            }
            else
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync("Hello Middleware<br/>");
            }
            // 调用下一个中间件
            await m_next(context);
        }
    }
}