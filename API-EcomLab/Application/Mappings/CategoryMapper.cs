using Application.DTOs;
using Application.DTOs.Category;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Mapper;

public class CategoryMapper : ICategoryMapper
{
    public Category FromCategoryDto(CategoryDto categoryDto) => new Category(categoryDto.Name);

    public CategoryDto ToCategoryDto(Category category) => new CategoryDto()
    {
        Id = category.Id,
        Name = category.Name
    };

    public IEnumerable<CategoryDto> ToCategoryDtoList(IEnumerable<Category> categories) =>
        categories.Select(ToCategoryDto).ToList();

    public PagedResultDto<CategoryDto> ToPagedResultDto(PagedResult<Category> pagedResult) => new PagedResultDto<CategoryDto>()
    {
        Items = pagedResult.Items.Select(ToCategoryDto).ToList(),
        TotalItems = pagedResult.TotalItems,
        PageNumber = pagedResult.PageNumber,
        PageSize = pagedResult.PageSize,
        TotalPages = pagedResult.TotalPages
    };
}
