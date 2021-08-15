using Microsoft.Extensions.DependencyInjection;
using Modular.Abstractions.Messaging;
using Modular.Infrastructure.Messaging.Brokers;
using Modular.Infrastructure.Messaging.Contexts;
using Modular.Infrastructure.Messaging.Dispatchers;

namespace Modular.Infrastructure.Messaging
{
    public static class Extensions
    {
        private const string SectionName = "messaging";
        
        public static IServiceCollection AddMessaging(this IServiceCollection services)
        {
            services.AddTransient<IMessageBroker, InMemoryMessageBroker>();
            services.AddTransient<IAsyncMessageDispatcher, AsyncMessageDispatcher>();
            services.AddSingleton<IMessageChannel, MessageChannel>();
            services.AddSingleton<IMessageContextProvider, MessageContextProvider>();
            services.AddSingleton<IMessageContextRegistry, MessageContextRegistry>();

            var messagingOptions = services.GetOptions<MessagingOptions>(SectionName);
            services.AddSingleton(messagingOptions);

            if (messagingOptions.UseAsyncDispatcher)
            {
                services.AddHostedService<AsyncDispatcherJob>();
            }
            
            return services;
        }
    }
}