using System;
using Microsoft.Extensions.Caching.Memory;
using Modular.Abstractions.Messaging;

namespace Modular.Infrastructure.Messaging.Contexts
{
    public class MessageContextRegistry : IMessageContextRegistry
    {
        private readonly IMemoryCache _cache;

        public MessageContextRegistry(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void Set(IMessage message, IMessageContext context)
            => _cache.Set(message, context, new MemoryCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromMinutes(1)
            });
    }
}