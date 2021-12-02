using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Contexts;

public interface IMessageContextRegistry
{
    void Set(IMessage message, IMessageContext context);
}