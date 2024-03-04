using ConsoleAppDependencyInjection.Interface;
using System;

namespace ConsoleAppDependencyInjection.Classes
{
    public class Connection : IConnection
    {
        public Guid ConnectionId { get; set; } = Guid.NewGuid();
        public void Open()
        {
            Console.WriteLine("Connection opened");
        }

        public void Close()
        {
            Console.WriteLine("Connection closed");
        }
    }
}
