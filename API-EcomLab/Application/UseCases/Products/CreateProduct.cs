using Application.DTO.Product;
using Application.DTOs.Product;
using Application.Mapper;
using Application.UseCases.Categories;
using Domain.Entities;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class CreateProduct(
    IGetBrandById getBrandById,
    IGetCategoryById getCategoryById,
    IProductRepository repository,
    IProductMapper mapper) : ICreateProduct
{
    public async Task<ProductResponseDto> Execute(ProductCreateDto productCreateDto)
    {
        var brand = await getBrandById.Execute(productCreateDto.BrandId)
            ?? throw new NotFoundException("Marca não encontrada");

        var categories = new List<Category>();
        foreach (var categoryId in productCreateDto.CategoryIds)
        {
            var category = await getCategoryById.Execute(categoryId);
            if (category != null)
                categories.Add(category);
        }

        var product = mapper.FromProductCreateDto(productCreateDto, brand, categories);

        var createdProduct = await repository.Create(product);

        return mapper.ToProductResponseDto(createdProduct);
    }
}

