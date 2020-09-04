using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace _01CreateWebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // // 第一种
            // var builder = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            // {
            //     webBuilder.UseStartup<Startup>();
            // });
            // // 创建Web宿主
            // var host = (IWebHost)builder.Build();
            // // 启动Web主机
            // host.Run();


            WebHost.CreateDefaultBuilder<Startup>(args).Build().Run();

            // CreateHostBuilder(args).Build().Run();
        }

        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
