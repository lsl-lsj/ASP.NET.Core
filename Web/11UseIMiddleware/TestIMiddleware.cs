using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace _11UseIMiddleware
{
    public class TestIMiddleware : IMiddleware
    {
        public TestIMiddleware()
        {
            Console.WriteLine($"类 {this.GetType().Name} 的构造函数被调用");
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // 添加两个响应头
            context.Response.Headers["item1"] = "hello";
            context.Response.Headers["item2"] = "hi";

            // 写入响应消息
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync("欢迎来到主页！<br/>");
        }
    }
}