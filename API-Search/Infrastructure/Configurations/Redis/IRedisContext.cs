using StackExchange.Redis;

namespace Infrastructure.Configurations.Redis;

public interface IRedisContext
{
    IDatabase Get();
}
