using Application.DTO.Product;
using Application.DTOs;
using Application.DTOs.Product;
using Domain.Abstractions;
using Domain.Entities;
using Domain.Event;
using Microsoft.Extensions.Configuration;

namespace Application.Mapper;

public class ProductMapper(
    ICategoryMapper categoryMapper,
    IConfiguration configuration) : IProductMapper
{
    public Product FromProductCreateDto(ProductCreateDto request, Brand brand, IEnumerable<Category>? categories = null)
    {
        var product = new Product(
            request.Name,
            request.Description,
            request.Ean,
            request.Sku,
            request.Stock,
            request.BasePrice,
            request.ImageUrl
        );

        product.BrandId = brand.Id;
        product.Brand = brand;

        if (categories != null)
        {
            product.Categories = categories.ToList();
        }

        return product;
    }

    public ProductResponseDto ToProductResponseDto(Product product) => new ProductResponseDto()
    {
        Id = product.Id,
        Name = product.Name,
        Description = product.Description,
        Ean = product.Ean,
        Sku = product.Sku,
        Stock = product.Stock,
        BasePrice = product.BasePrice,
        ImageUrl = product.ImageUrl,
        BrandName = product.Brand.Name,
        Categories = categoryMapper.ToCategoryDtoList(product.Categories)
    };

    public PagedResultDto<ProductResponseDto> ToPagedResultDto(PagedResult<Product> pagedResult) => new PagedResultDto<ProductResponseDto>()
    {
        Items = pagedResult.Items.Select(ToProductResponseDto).ToList(),
        TotalItems = pagedResult.TotalItems,
        PageNumber = pagedResult.PageNumber,
        PageSize = pagedResult.PageSize,
        TotalPages = pagedResult.TotalPages
    };

    public KafkaEvent<ProductEvent> ToKafkaEvent(Product product, string type)
    {
        var topic = configuration.GetValue<string>($"Kafka:Topics:{type}") ?? "";

        return new KafkaEvent<ProductEvent>()
        {
            Id = Guid.NewGuid(),
            Type = type,
            Version = "1.0",
            Source = "api-ecomlab",
            OccurredAt = DateTime.Now,
            Topic = topic,
            Data = ToProductEvent(product)

        };
    }

    private ProductEvent ToProductEvent(Product product) => new ProductEvent()
    {
        Id = Guid.NewGuid(),
        ProductId = product.Id,
        Name = product.Name,
        Description = product.Description,
        Ean = product.Ean,
        Sku = product.Sku,
        InStock = product.Stock > 0,
        BasePrice = product.BasePrice,
        SalePrice = product.BasePrice,
        Price = product.BasePrice,
        IsOnSale = false,
        OnSaleEnd = DateTime.MinValue,
        CreatedAt = product.CreatedAt,
        UpdatedAt = product.UpdatedAt,
        ImageUrl = product.ImageUrl,
        Brand = product.Brand.Name,
        Categories = product.Categories
           .Select(category => category.Name)
           .ToList(),
        IsActive = product.IsActive
    };
}
