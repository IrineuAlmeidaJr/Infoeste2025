using Application.DTOs.Abstractions;
using Application.DTOs.Category;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Mapper;

public interface ICategoryMapper
{
    Category FromCategoryDto(CategoryDto categoryDto);
    CategoryDto ToCategoryDto(Category category);
    IEnumerable<CategoryDto> ToCategoryDtoList(IEnumerable<Category> categories);
    PagedResultDto<CategoryDto> ToPagedResultDto(PagedResult<Category> categories);
}
