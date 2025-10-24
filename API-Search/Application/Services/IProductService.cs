using Application.DTO.Products;
using Application.DTOs;
using Domain.Entities;
using Domain.Event;

namespace Application.Services;

public interface IProductService
{
    Task Create(KafkaEvent<Product> productEvent);
    Task Update(KafkaEvent<Product> productEvent);
    Task<ProductResponseDto> GetById(Guid id);
    Task<PagedResultDto<ProductResponseDto>> GetProductsPaged(int page, int pageSize, string name,
        string orderBy, string sortDirection, bool isOnSale, double priceMin, double priceMax);
}
