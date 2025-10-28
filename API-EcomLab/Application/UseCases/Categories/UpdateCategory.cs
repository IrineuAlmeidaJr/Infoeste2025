using Application.DTOs.Category;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class UpdateCategory(
    ICategoryRepository repository,
    ICacheRepository cache,
    ICategoryMapper mapper) : IUpdateCategory
{
    public async Task<CategoryDto> Execute(long id, CategoryDto categoryDto)
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
}

