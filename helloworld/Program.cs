using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHostBuilder => webHostBuilder
                //.UseKestrel()
                .ConfigureServices(services => services
                    .AddRouting()
                    .AddControllersWithViews())
                .Configure(app => app
                    .UseRouting()
                    .UseEndpoints(endpoints => endpoints.MapControllers())
                    /*.Run(
                    context => context.Response.WriteAsync("Hello World!")
                    )*/))
                .Build()
                .Run();
            Console.WriteLine("Hello World!");
        }
    }
}
