using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace _09RequestBody
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    // 修改正文大小限制
                    webBuilder.UseKestrel(
                        o =>
                        {
                            o.Limits.MaxRequestBodySize = 5000000000;
                        }
                    );
                });
    }
}
