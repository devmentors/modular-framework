using System.Threading.Channels;

namespace Modular.Infrastructure.Messaging.Dispatchers
{
    public interface IMessageChannel
    {
        ChannelReader<MessageEnvelope> Reader { get; }
        ChannelWriter<MessageEnvelope> Writer { get; }
    }
}