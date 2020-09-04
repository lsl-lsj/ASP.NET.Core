using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _03UseIStartup
{
    public class Startup : IStartup
    {
        private IHostEnvironment _env;

        public Startup(IHostEnvironment env)
        {
            _env = env;
        }
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; charset=UTF-8";
                await context.Response.WriteAsync($"我的 Web应用程序，它运行在{_env.EnvironmentName} 环境中");
            });
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            return services.BuildServiceProvider();
        }
    }
}
