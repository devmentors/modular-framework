using System;
using System.Threading.Tasks;
using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Outbox
{
    public interface IOutbox
    {
        bool Enabled { get; }
        Task SaveAsync(params IMessage[] messages);
        Task PublishUnsentAsync();
        Task CleanupAsync(DateTime? to = null);
    }
}