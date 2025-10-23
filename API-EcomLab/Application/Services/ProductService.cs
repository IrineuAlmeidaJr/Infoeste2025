using Application.DTO;
using Application.DTO.Product;
using Application.DTOs;
using Application.DTOs.Product;
using Application.Mapper;
using Domain.Entities;
using Domain.Exception;
using Domain.Repository;

namespace Application.Services;

public class ProductService(
    IProductRepository productRepository,
    IBrandRepository brandRepository,
    ICategoryRepository categoryRepository,
    ICacheRepository cache,
    IProductMapper mapper) : IProductService
{
    public async Task<ProductResponseDto> Create(ProductCreateDto productCreateDto)
    {
        var brand = await brandRepository.GetById(productCreateDto.BrandId)
            ?? throw new NotFoundException("Marca não encontrada");

        var categories = new List<Category>();
        foreach (var categoryId in productCreateDto.CategoryIds)
        {
            var category = await categoryRepository.GetById(categoryId);
            if (category != null)
                categories.Add(category);
        }

        var product = mapper.FromProductCreateDto(productCreateDto, brand, categories);

        var createdProduct = await productRepository.Create(product);

        return mapper.ToProductResponseDto(createdProduct);
    }

    public async Task<ProductResponseDto> Update(long id, ProductUpdateDto productUpdateDto)
    {
        if (productUpdateDto.Id != id)
            throw new NotFoundException("Produto não foi encontrada e não pôde ser atualizado");

        var product = await productRepository.GetById(id);
        if (product == null)
            throw new NotFoundException("Produto não foi encontrado e não pôde ser atualizado");

        product.Update(productUpdateDto.Name, productUpdateDto.Description, productUpdateDto.Ean,
            productUpdateDto.Sku, productUpdateDto.Stock, productUpdateDto.BasePrice, productUpdateDto.ImageUrl);
        var updatedProduct = await productRepository.Update(product);

        var cacheKey = $"product-{id}";
        await cache.RemoveCache(cacheKey);

        return mapper.ToProductResponseDto(updatedProduct);
    }

    public async Task SetProductStatus(long id, bool isActive)
    {
        var product = await productRepository.GetById(id);
        if (product == null)
            throw new NotFoundException("Produto não foi encontrado e não pôde ser atualizado");

        product.SetProductStatus(isActive);

        await productRepository.Update(product);
    }

    public async Task<ProductResponseDto> GetById(long id)
    {
        var cacheKey = $"product-{id}";
        var cachedProductRequestDto = await cache.ReadCache<ProductResponseDto>(cacheKey);

        if (cachedProductRequestDto != null)
            return cachedProductRequestDto;

        var product = await productRepository.GetById(id);
        if (product == null)
            throw new NotFoundException("Produto não foi encontrado");

        var productResponseDto = mapper.ToProductResponseDto(product);
        await cache.SaveCache(cacheKey, productResponseDto);

        return productResponseDto;
    }

    public async Task<PagedResultDto<ProductResponseDto>> GetProductsPaged(string name, int page, int pageSize)
    {
        var products = await productRepository.GetProductsPaged(name, page, pageSize);
        if (!products.Items.Any())
            throw new NotFoundException("Nenhum produto foi encontrado");

        var productsPagedResultDto = mapper.ToPagedResultDto(products);

        return productsPagedResultDto;
    }
}
