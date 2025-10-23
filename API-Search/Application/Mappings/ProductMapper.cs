using Domain.Entities;
using Domain.Event;

namespace Application.Mapper;

public class ProductMapper : IProductMapper
{
    public Product FromKafkaProductEvent(KafkaEvent<Product> productEvent)
    {
        var product = productEvent.Data;

        return new Product()
        {
            Id = product.Id,
            ProductId = product.ProductId,
            Name = product.Name,
            Description = product.Description,
            Ean = product.Ean,
            Sku = product.Sku,
            InStock = product.InStock,
            BasePrice = product.BasePrice,
            SalePrice = product.SalePrice,
            IsOnSale = product.IsOnSale,
            OnSaleEnd = product.OnSaleEnd,
            CreatedAt = product.CreatedAt,
            UpdatedAt = product.UpdatedAt,
            ImageUrl = product.ImageUrl,
            Brand = product.Brand,
            Categories = product.Categories,
            IsActive = product.IsActive
        };
    }

    //public ProductResponseDto ToProductResponseDto(Product product) => new ProductResponseDto()
    //{
    //    Id = product.Id,
    //    Name = product.Name,
    //    Description = product.Description,
    //    Ean = product.Ean,
    //    Sku = product.Sku,
    //    Stock = product.Stock,
    //    BasePrice = product.BasePrice,
    //    ImageUrl = product.ImageUrl,
    //    BrandName = product.Brand.Name,
    //    Categories = categoryMapper.ToCategoryDtoList(product.Categories)
    //};

    //public PagedResultDto<ProductResponseDto> ToPagedResultDto(PagedResult<Product> pagedResult) => new PagedResultDto<ProductResponseDto>()
    //{
    //    Items = pagedResult.Items.Select(ToProductResponseDto).ToList(),
    //    TotalItems = pagedResult.TotalItems,
    //    PageNumber = pagedResult.PageNumber,
    //    PageSize = pagedResult.PageSize,
    //    TotalPages = pagedResult.TotalPages
    //};
}
