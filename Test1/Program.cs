using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Test1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        // no more web.config
        public static IWebHost BuildWebHost(string[] args) =>
            // configuring the web server environmnet
            // use Kestrel webserver
            // IIS integration
            //sets up Logging
            //IConfiguration service made avaialble reading JSON file
            //
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
