using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MyWebApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel(options =>
                {
                    options.Listen(IPAddress.Any, 8080);
                })
                .Configure(app =>
                {
                    //create a endpoint that will return a simple message a paramater
                    app.Map("/hello", app =>
                    {
                        app.Run(async context =>
                        {
                            var name = context.Request.Query["name"];
                            await context.Response.WriteAsync($"Hello {name}");
                        });
                    });
                    app.Map("/goodbye", app =>
                    {
                        app.Run(async context =>
                        {
                            var name = context.Request.Query["name"];
                            await context.Response.WriteAsync($"Goodbye {name}");
                        });
                    });
                })
                .Build();

            await host.RunAsync();
        }
    }
}
