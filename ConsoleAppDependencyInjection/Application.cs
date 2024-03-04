using ConsoleAppDependencyInjection.Services;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleAppDependencyInjection
{
    public class Application : IApplication
    {
        private readonly ILogger<Application> _logger;
        private readonly IConnectionManagerService _connectionManagerService;
        public Application(ILogger<Application> logger, IConnectionManagerService connectionManagerService)
        {
            _logger = logger;
            _connectionManagerService = connectionManagerService;
        }
        public void Run()
        {
            var connection = _connectionManagerService.CreateConnection();
            connection.Open();
            _logger.LogInformation("Logger Application is running...");
        }
    }
}
