using System;

namespace ConsoleAppDependencyInjection.Interface
{
    public interface IConnection
    {
        Guid ConnectionId { get; set; }

        void Open();

        void Close();
    }
}
