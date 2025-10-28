using Application.DTO.Product;
using Application.DTOs;
using Application.Mapper;
using Application.UseCases.Brands;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Products;

public class GetProductsPaged(
    IProductRepository repository,
    IProductMapper mapper) : IGetProductsPaged
{
    public async Task<PagedResultDto<ProductResponseDto>> Execute(string name, int page, int pageSize)
    {
        var products = await repository.GetProductsPaged(name, page, pageSize);
        if (!products.Items.Any())
            throw new NotFoundException("Nenhum produto foi encontrado");

        var productsPagedResultDto = mapper.ToPagedResultDto(products);

        return productsPagedResultDto;
    }
}
