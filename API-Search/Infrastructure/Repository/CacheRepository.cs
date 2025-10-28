using Domain.Repository;

namespace Infrastructure.Repository;

public class CacheRepository (IRedisRepository redisRepository) : ICacheRepository
{
    public async Task<bool> SaveCache<T>(string key, T content, TimeSpan? expiry = null)
    {
        return await redisRepository.SaveAsync(key, content, expiry);
    }

    public async Task<T?> ReadCache<T>(string key)
    {
        return await redisRepository.GetDataAsync<T>(key);
    }

    public Task<bool> RemoveCache(string key)
    {
        return redisRepository.RemoveAsync(key);
    }    
}
