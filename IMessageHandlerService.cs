using System;
using System.Threading.Tasks;


namespace MessageBus.Abstractions;

public interface IMessageHandlerService
{
    string Topic { get; }
    Task HandleAsync(IServiceProvider serviceProvider);
}
