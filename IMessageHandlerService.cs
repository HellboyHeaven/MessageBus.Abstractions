using MessageBus.Abstractions;

public interface IMessageHandlerService
{
    string Topic { get; }
    Task HandleAsync(IServiceProvider serviceProvider);
}
