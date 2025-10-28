using Infrastructure.Configurations.Redis;
using Domain.Repository;
using Newtonsoft.Json;

namespace Infrastructure.Repository.Redis;

public class RedisRepository(IRedisContext redis) : IRedisRepository
{
    public async Task<T?> GetDataAsync<T>(string key)
    {
        var databasase = redis.Get();
        var cache = await databasase.StringGetAsync(key);
        if (!cache.IsNullOrEmpty)
            return JsonConvert.DeserializeObject<T>(cache);
        return default;
    }

    public async Task<bool> SaveAsync<T>(string key, T content, TimeSpan? expiry = null)
    {
        var database = redis.Get();
        var serializedContent = JsonConvert.SerializeObject(content);

        var expiration = expiry ?? TimeSpan.FromMinutes(60);

        return await database.StringSetAsync(key, serializedContent, expiration);
    }

    public async Task<bool> RemoveAsync(string key)
    {
        var database = redis.Get();
        return await database.KeyDeleteAsync(key);
    }
}
