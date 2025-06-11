using System;
using System.Threading;
using System.Threading.Tasks;


namespace MessageBus.Abstractions;

public interface IMessageConsumer : IDisposable
{
    Task StartAsync(CancellationToken cancellationToken = default);
    Task StopAsync(CancellationToken cancellationToken = default);
    Task Subscribe<T>(string topic, Func<string, T, Task> messageHandler) where T : IMessage;
    Task<T?> WaitForMessageAsync<T>(string topic, string key, TimeSpan timeout) where T : IMessage;
}
