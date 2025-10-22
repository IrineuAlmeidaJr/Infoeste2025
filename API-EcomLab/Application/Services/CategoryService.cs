using Application.DTOs;
using Application.DTOs.Category;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.Services;

public class CategoryService(
    ICategoryRepository repository,
    ICacheRepository cache,
    ICategoryMapper mapper) : ICategoryService
{
    public async Task<CategoryDto> Create(CategoryDto categoryDto)
    {
        var category = mapper.FromCategoryDto(categoryDto);
        var createdCategory = await repository.Create(category);

        return mapper.ToCategoryDto(createdCategory);
    }

    public async Task<CategoryDto> Update(long id, CategoryDto categoryDto)
    {
        if (categoryDto.Id != id)
            throw new NotFoundException("Categoria não foi encontrada e não pôde ser atualizada");

        var category = await repository.GetById(id);
        if (category == null)
            throw new NotFoundException("Categoria não foi encontrada e não pôde ser atualizada");

        category.Update(categoryDto.Name);
        var updatedCategory = await repository.Update(category);

        var cacheKey = $"category-{id}";
        await cache.RemoveCache(cacheKey);

        return mapper.ToCategoryDto(updatedCategory);
    }

    public async Task Remove(long id)
    {
        var removedCategory = await repository.Remove(id);
        if (removedCategory == null)
            throw new NotFoundException("Categoria não foi encontrada e não pôde ser removida");
    }

    public async Task<CategoryDto> GetById(long id)
    {
        var cacheKey = $"category-{id}";
        var cachedCategoryDto = await cache.ReadCache<CategoryDto>(cacheKey);

        if (cachedCategoryDto != null)
            return cachedCategoryDto;

        var category = await repository.GetById(id);
        if (category == null)
            throw new NotFoundException("Categoria não foi encontrada");

        var categoryDto = mapper.ToCategoryDto(category);
        await cache.SaveCache(cacheKey, categoryDto);

        return categoryDto;
    }

    public async Task<PagedResultDto<CategoryDto>> GetCategoriesPaged(string name, int page, int pageSize)
    {
        var categories = await repository.GetCategoriesPaged(name, page, pageSize);
        if (!categories.Items.Any())
            throw new NotFoundException("Nenhuma categoria foi encontrada");

        var categoriesPagedResultDto = mapper.ToPagedResultDto(categories);

        return categoriesPagedResultDto;
    }
}
