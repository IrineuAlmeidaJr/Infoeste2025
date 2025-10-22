using Application.DTO.Product;
using Application.DTOs;
using Application.DTOs.Product;

namespace Application.Services;

public interface IProductService
{
    Task<ProductResponseDto> Create(ProductCreateDto productRequestDto);
    Task<ProductResponseDto> Update(long id, ProductUpdateDto productUpdateDto);
    Task Remove(long id);
    Task<ProductResponseDto> GetById(long id);
    Task<PagedResultDto<ProductResponseDto>> GetProductsPaged(string name, int page, int pageSize);
}
