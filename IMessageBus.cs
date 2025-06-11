namespace MessageBus.Abstractions;

public interface IMessageBus : IDisposable
{
    Task PublishAsync<T>(string topic, string key, T message, CancellationToken cancellationToken = default)
        where T : IMessage;

    Task Subscribe<T>(string topic, Func<string, T, Task> messageHandler) where T : IMessage;
    Task<T?> WaitForMessageAsync<T>(string topic, string key, TimeSpan timeout) where T : IMessage;
    Task RespondAsync<T>(string topic, string key, T message, CancellationToken cancellationToken = default) where T : IMessage;
    internal Task StartAsync(CancellationToken cancellationToken = default);
    internal Task StopAsync(CancellationToken cancellationToken = default);
}
