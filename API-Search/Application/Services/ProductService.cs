using Application.DTO.Products;
using Application.DTOs;
using Application.DTOs.Products;
using Application.Mapper;
using Domain.Entities;
using Domain.Event;
using Domain.Exception;
using Domain.Repository;

namespace Application.Services;

public class ProductService(
    IProductRepository repository,
    ICacheRepository cache,
    IProductMapper mapper) : IProductService
{
    public async Task Create(KafkaEvent<Product> productEvent)
    {
        var product = mapper.FromKafkaProductEvent(productEvent);

        await repository.Create(product);
    }

    public Task Update(KafkaEvent<Product> productEvent)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductResponseDto> GetById(Guid id)
    {
        var product = await repository.GetById(id);
        if (product == null)
            throw new NotFoundException("Produto não foi encontrado");

        return mapper.ToProductResponseDto(product);
    }

    public async Task<PagedResultDto<ProductResponseDto>> GetProductsPaged(int page, int pageSize, string name,
        string orderBy, string sortDirection, bool isOnSale, double priceMin, double priceMax)
    {
        var productQueryDto = new ProductQueryDto(page, pageSize, name, orderBy, sortDirection,
            isOnSale, priceMin, priceMax);

        var productPagedResult = await repository.GetProductsPaged(productQueryDto);
        if (!productPagedResult.Items.Any())
            throw new NotFoundException("Nenhum produto foi encontrado");

        var productsPagedResultDto = mapper.ToPagedResultDto(productPagedResult);

        return productsPagedResultDto;
    }
}
