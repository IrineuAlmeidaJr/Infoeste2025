using Application.DTO.Product;
using Application.DTOs;

namespace Application.UseCases.Brands;

public interface IGetProductsPaged
{
    Task<PagedResultDto<ProductResponseDto>> Execute(string name, int page, int pageSize);
}
