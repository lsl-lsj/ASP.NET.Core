using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace _03UseIStartup
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = new WebHostBuilder()
                            .UseKestrel()
                            .UseIISIntegration()
                            .UseStartup<Startup>()
                            .UseUrls("http://localhost:5456","http://localhost:4555");

            builder.Build().Run();

        //    CreateHostBuilder(args).Build().Run();
        }

        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
