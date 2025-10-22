namespace Domain.Repository;

public interface ICacheRepository
{
    Task<bool> SaveCache<T>(string key, T content, TimeSpan? expiry = null);
    Task<T?> ReadCache<T>(string key);
    Task<bool> RemoveCache(string key);
}
