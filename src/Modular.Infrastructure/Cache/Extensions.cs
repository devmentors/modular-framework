using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Modular.Infrastructure.Cache;

public static class Extensions
{
    public static IServiceCollection AddRedisCache(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetSection("redis");
        var options = section.GetOptions<RedisOptions>();
        services.Configure<RedisOptions>(section);
        services.AddStackExchangeRedisCache(o => o.Configuration = options.ConnectionString);
        services.AddScoped<ICache, RedisCache>();
        services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(options.ConnectionString));
        services.AddScoped(ctx => ctx.GetRequiredService<IConnectionMultiplexer>().GetDatabase());
            
        return services;
    }
}