using Application.DTOs.Category;

namespace Application.UseCases.Brands;

public interface ICreateCategory
{
    Task<CategoryDto> Execute(CategoryDto categoryDto);
}
