using ConsoleAppDependencyInjection.Interface;
using System;

namespace ConsoleAppDependencyInjection.Classes
{
    public class ConnectionPool : IConnectionPool
    {
        public void Add(IConnection connection)
        {
            Console.WriteLine("Connection added to pool");
        }

        public IConnection Get(Guid connectionId)
        {
            Console.WriteLine("Connection get from pool");
            return new Connection();
        }

        public void Remove(Guid connectionId)
        {
            Console.WriteLine("Connection removed to pool");
        }
    }
}
