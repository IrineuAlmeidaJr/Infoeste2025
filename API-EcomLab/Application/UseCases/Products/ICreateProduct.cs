using Application.DTO.Product;
using Application.DTOs.Product;

namespace Application.UseCases.Products;

public interface ICreateProduct
{
    Task<ProductResponseDto> Execute(ProductCreateDto brandDto);
}
