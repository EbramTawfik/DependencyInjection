using ConsoleAppDependencyInjection.Interface;
using System;

namespace ConsoleAppDependencyInjection.Classes
{
    public interface IConnectionPool
    {
        void Add(IConnection connection);
        IConnection Get(Guid connectionId);
        void Remove(Guid connectionId);
    }
}