using Application.DTOs.Category;
using Application.Mapper;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class CreateCategory(
    ICategoryRepository repository,
    ICategoryMapper mapper) : ICreateCategory
{
    public async Task<CategoryDto> Execute(CategoryDto categoryDto)
    {
        var category = mapper.FromCategoryDto(categoryDto);
        var createdCategory = await repository.Create(category);

        return mapper.ToCategoryDto(createdCategory);
    }
}

