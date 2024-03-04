using Microsoft.Extensions.Logging;
using System;

namespace ConsoleAppDependencyInjection
{
    public class Application : IApplication
    {
        private readonly ILogger<Application> _logger;
        public Application(ILogger<Application> logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            _logger.LogInformation("Logger Application is running...");
            Console.WriteLine("Application is running...");
        }
    }
}
