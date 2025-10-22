using Application.DTO.Product;
using Application.DTOs;
using Application.DTOs.Product;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Mapper;

public class ProductMapper(ICategoryMapper categoryMapper) : IProductMapper
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
}
