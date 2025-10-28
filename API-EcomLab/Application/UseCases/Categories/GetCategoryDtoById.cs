using Application.DTOs.Category;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class GetCategoryDtoById(
    ICategoryRepository repository,
    ICacheRepository cache,
    ICategoryMapper mapper) : IGetCategoryDtoById
{
    public async Task<CategoryDto> Execute(long id)
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
}

