using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace _02ConfigureURL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                            .UseKestrel()
                            .UseIISIntegration()
                            .UseStartup<Startup>();

            // 配置Web服务器的Url

            // 方式1
            // .UseUrls("http://localhost:6500","http://*:7000");

            // 方式2
            // .UseSetting(WebHostDefaults.ServerUrlsKey,"http://localhost:200;http://*.50");

            // 方式3
            ConfigurationBuilder config = new ConfigurationBuilder();

            config.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("host.json");

            builder.UseConfiguration(config.Build());

            builder.Build().Run();
        }
    }
}
