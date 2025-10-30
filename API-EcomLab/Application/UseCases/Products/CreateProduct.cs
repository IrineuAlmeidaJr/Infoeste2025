using Application.DTO.Product;
using Application.DTOs.Product;
using Application.Event;
using Application.Mapper;
using Application.UseCases.Brands;
using Application.UseCases.Categories;
using Domain.Entities;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Products;

public class CreateProduct(
    IGetBrandById getBrandById,
    IGetCategoryById getCategoryById,
    IProductRepository repository,
    ICreateProductEventPublisher publisher,
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

        var productEvent = mapper.ToKafkaEvent(createdProduct, "CreateProduct");
        try
        {
            await publisher.PublishAsync(productEvent);
        }
        catch (Exception)
        {
            await repository.Remove(product.Id);
            throw;
        }

        return mapper.ToProductResponseDto(createdProduct);
    }
}

