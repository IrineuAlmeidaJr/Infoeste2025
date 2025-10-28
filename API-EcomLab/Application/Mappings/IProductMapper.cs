using Application.DTO.Product;
using Application.DTOs;
using Application.DTOs.Product;
using Domain.Abstractions;
using Domain.Entities;
using Domain.Event;

namespace Application.Mapper;

public interface IProductMapper
{
    Product FromProductCreateDto(ProductCreateDto request, Brand brand, IEnumerable<Category>? categories = null);
    ProductResponseDto ToProductResponseDto(Product product);
    PagedResultDto<ProductResponseDto> ToPagedResultDto(PagedResult<Product> pagedResult);
    KafkaEvent<ProductEvent> ToKafkaEvent(Product product, string type);
}
