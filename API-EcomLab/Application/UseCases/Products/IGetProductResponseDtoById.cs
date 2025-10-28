using Application.DTO.Product;

namespace Application.UseCases.Products;

public interface IGetProductResponseDtoById
{
    Task<ProductResponseDto> Execute(long id);
}
