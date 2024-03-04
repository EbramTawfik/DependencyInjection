using ConsoleAppDependencyInjection.Classes;
using ConsoleAppDependencyInjection.Interface;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleAppDependencyInjection.Services
{
    public class ConnectionManagerService : IConnectionManagerService
    {
        private readonly IConnectionPool _connectionPool;
        private readonly ILogger<IConnectionManagerService> _logger;
        public ConnectionManagerService(ILogger<IConnectionManagerService> logger)
        {
            _logger = logger;
            _connectionPool = new ConnectionPool();
        }

        public IConnection CreateConnection()
        {
            _logger.LogInformation("Create connection");
            IConnection connection = new Connection();
            _connectionPool.Add(connection);
            return connection;
        }

        public void Open(Guid connectionId)
        {
            _logger.LogInformation("Open connection");
            IConnection connection = _connectionPool.Get(connectionId);
            connection.Open();
        }

        public void Close(Guid connectionId)
        {
            _logger.LogInformation("Close connection");
            IConnection connection = _connectionPool.Get(connectionId);
            connection.Close();
            _connectionPool.Remove(connectionId);
        }
    }
}
