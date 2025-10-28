using Application.DTO.Product;
using Application.DTOs.Product;

namespace Application.UseCases.Products;

public interface IUpdateProduct
{
    Task<ProductResponseDto> Execute(long id, ProductUpdateDto categoryDto);
}
