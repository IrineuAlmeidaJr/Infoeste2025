using Application.DTOs.Abstractions;
using Application.DTOs.Category;

namespace Application.Services;

public interface ICategoryService
{
    Task<CategoryDto> Create(CategoryDto categoryDto);
    Task<CategoryDto> Update(long id, CategoryDto categoryDto);
    Task Remove(long id);
    Task<CategoryDto> GetById(long id);
    Task<PagedResultDto<CategoryDto>> GetCategoriesPaged(string name, int page, int pageSize);
}
