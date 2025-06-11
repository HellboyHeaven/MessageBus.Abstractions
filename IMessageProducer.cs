using System;
using System.Threading;
using System.Threading.Tasks;


namespace MessageBus.Abstractions;

public interface IMessageProducer : IDisposable
{
    Task ProduceAsync<T>(string topic, string key, T message, CancellationToken cancellationToken = default)
        where T : IMessage;
}
