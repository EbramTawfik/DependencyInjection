using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleAppDependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IApplication, Application>();
                })
                .Build();
            var app = host.Services.GetRequiredService<IApplication>();
            app.Run();
            Console.ReadKey();
        }
    }
}
