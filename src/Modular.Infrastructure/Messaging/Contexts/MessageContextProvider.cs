using Microsoft.Extensions.Caching.Memory;
using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Contexts
{
    public class MessageContextProvider : IMessageContextProvider
    {
        private readonly IMemoryCache _cache;

        public MessageContextProvider(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IMessageContext Get(IMessage message) => _cache.Get<IMessageContext>(message);
    }
}