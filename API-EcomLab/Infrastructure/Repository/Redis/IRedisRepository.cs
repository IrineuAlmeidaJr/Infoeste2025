namespace Domain.Repository;

public interface IRedisRepository
{
    Task<bool> SaveAsync<TKey>(string key, TKey content, TimeSpan? ttl = null);
    Task<TKey?> GetDataAsync<TKey>(string key);
    Task<bool> RemoveAsync(string key);
}