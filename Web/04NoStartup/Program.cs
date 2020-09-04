using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace _04NoStartup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                            .UseKestrel()
                            .UseIISIntegration()
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseUrls("http://localhost:5456", "http://localhost:4555")
                            .ConfigureServices(services =>
                            {
                                services.AddRouting();

                            }).Configure(app =>
                            {

                                /* app.Run(async (context) =>
                                {
                                    context.Response.ContentType = "text/html; charset=UTF-8";
                                    await context.Response.WriteAsync($"我的 Web应用程序");
                                }); */

                                app.UseRouting();

                                app.UseEndpoints(endpoints =>
                                {
                                    endpoints.MapGet("/", async context =>
                                    {
                                        await context.Response.WriteAsync("Hello World!");
                                    });
                                });
                            });

            builder.Build().Run();
        }
    }
}
