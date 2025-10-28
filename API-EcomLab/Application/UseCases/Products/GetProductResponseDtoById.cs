using Application.DTO.Product;
using Application.Mapper;
using Domain.Entities;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Products;

public class GetProductResponseDtoById(
    IProductRepository repository,
    ICacheRepository cache,
    IProductMapper mapper) : IGetProductResponseDtoById
{
    public async Task<ProductResponseDto> Execute(long id)
    {
        var cacheKey = $"product-{id}";
        var cachedProductRequestDto = await cache.ReadCache<ProductResponseDto>(cacheKey);

        if (cachedProductRequestDto != null)
            return cachedProductRequestDto;

        var product = await repository.GetById(id);
        if (product == null)
            throw new NotFoundException("Produto não foi encontrado");

        var productResponseDto = mapper.ToProductResponseDto(product);
        await cache.SaveCache(cacheKey, productResponseDto);

        return productResponseDto;
    }
}

