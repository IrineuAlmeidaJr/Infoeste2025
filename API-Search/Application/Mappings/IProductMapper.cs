using Application.DTO.Products;
using Application.DTOs;
using Domain.Abstractions;
using Domain.Entities;
using Domain.Event;

namespace Application.Mapper;

public interface IProductMapper
{
    Product FromKafkaProductEvent(KafkaEvent<Product> productEvent);
    ProductResponseDto ToProductResponseDto(Product product);
    PagedResultDto<ProductResponseDto> ToPagedResultDto(PagedResult<Product> pagedResult) => new PagedResultDto<ProductResponseDto>();
}
