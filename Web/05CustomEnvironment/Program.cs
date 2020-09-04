using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _05CustomEnvironment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseIISIntegration()
                .UseKestrel()
                .UseEnvironment("Preview")
                .UseUrls("http://localhost:6200")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build().Run();
        }
    }
}
