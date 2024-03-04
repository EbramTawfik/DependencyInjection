using ConsoleAppDependencyInjection.Interface;
using System;

namespace ConsoleAppDependencyInjection.Services
{
    public interface IConnectionManagerService
    {
        IConnection CreateConnection();
        void Open(Guid connectionId);
        void Close(Guid connectionId);
    }
}