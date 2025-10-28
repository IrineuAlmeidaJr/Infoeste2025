using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class RemoveBrand(
    IBrandRepository repository,
    ICacheRepository cache) : IRemoveBrand
{
    public async Task Execute(long id)
    {
        var removedBrand = await repository.Remove(id);
        if (removedBrand == null)
            throw new NotFoundException("Marca não foi encontrada e não pôde ser removida");

        var cacheKey = $"brand-{id}";
        await cache.RemoveCache(cacheKey);
    }
}
