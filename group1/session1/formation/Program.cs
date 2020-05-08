using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace formation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
            .ConfigureServices((IServiceCollection services) => {})
            .Configure((IApplicationBuilder app) => {
                    app.Run(async (context) =>
                    {
                        await context.Response.WriteAsync("Welcome to Team AKKA!");
                    });
            });

            
            //CreateWebHostBuilder(args).Build().Run();
        }

    }
}
