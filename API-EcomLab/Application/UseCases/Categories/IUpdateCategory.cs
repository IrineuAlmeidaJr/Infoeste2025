using Application.DTOs.Category;

namespace Application.UseCases.Brands;

public interface IUpdateCategory
{
    Task<CategoryDto> Execute(long id, CategoryDto categoryDto);
}
