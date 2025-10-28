using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Products;

public class RemoveProduct(
    IProductRepository repository,
    ICacheRepository cache) : IRemoveProduct
{
    public async Task Execute(long id)
    {
        var removedProduct = await repository.Remove(id);
        if (removedProduct == null)
            throw new NotFoundException("Produto não foi encontrado e não pôde ser removido");

        var cacheKey = $"product-{id}";
        await cache.RemoveCache(cacheKey);
    }
}
