using Application.DTO.Product;
using Application.DTOs.Product;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Products;

public class UpdateProduct(
    IProductRepository repository,
    ICacheRepository cache,
    IProductMapper mapper) : IUpdateProduct
{
    public async Task<ProductResponseDto> Execute(long id, ProductUpdateDto productUpdateDto)
    {
        if (productUpdateDto.Id != id)
            throw new NotFoundException("Produto não foi encontrada e não pôde ser atualizado");

        var product = await repository.GetById(id);
        if (product == null)
            throw new NotFoundException("Produto não foi encontrado e não pôde ser atualizado");

        product.Update(productUpdateDto.Name, productUpdateDto.Description, productUpdateDto.Ean,
            productUpdateDto.Sku, productUpdateDto.Stock, productUpdateDto.BasePrice, productUpdateDto.ImageUrl);
        var updatedProduct = await repository.Update(product);

        var cacheKey = $"product-{id}";
        await cache.RemoveCache(cacheKey);

        return mapper.ToProductResponseDto(updatedProduct);
    }
}

