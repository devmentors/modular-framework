using System.Threading.Tasks;
using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Outbox
{
    public interface IOutboxBroker
    {
        bool Enabled { get; }
        Task SendAsync(params IMessage[] messages);
    }
}