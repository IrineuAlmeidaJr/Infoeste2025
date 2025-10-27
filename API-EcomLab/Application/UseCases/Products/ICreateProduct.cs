using Application.DTO.Product;
using Application.DTOs.Product;

namespace Application.UseCases.Brands;

public interface ICreateProduct
{
    Task<ProductResponseDto> Execute(ProductCreateDto brandDto);
}
