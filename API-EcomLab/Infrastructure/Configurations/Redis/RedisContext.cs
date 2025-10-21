using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace Infrastructure.Configurations.Redis;

public class RedisContext : IRedisContext
{
    private readonly IConnectionMultiplexer _redis;
    public RedisContext(IConfiguration configuration)
    {
        _redis = ConnectionMultiplexer.Connect(configuration.GetValue<string>("ConnectionStrings:Redis"));
    }

    public IDatabase Get()
    {
        return _redis.GetDatabase();
    }
}
