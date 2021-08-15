using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Dispatchers
{
    public record MessageEnvelope(IMessage Message, IMessageContext MessageContext);
}