using System.Threading;
using System.Threading.Tasks;
using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Dispatchers;

public interface IAsyncMessageDispatcher
{
    Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken = default)
        where TMessage : class, IMessage;
}