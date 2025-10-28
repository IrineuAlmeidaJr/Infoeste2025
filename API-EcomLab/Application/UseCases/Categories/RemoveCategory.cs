using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class RemoveCategory(
    ICategoryRepository repository,
    ICacheRepository cache) : IRemoveCategory
{
    public async Task Execute(long id)
    {
        var removedCategory = await repository.Remove(id);
        if (removedCategory == null)
            throw new NotFoundException("Categoria não foi encontrada e não pôde ser removida");

        var cacheKey = $"category-{id}";
        await cache.RemoveCache(cacheKey);
    }
}
