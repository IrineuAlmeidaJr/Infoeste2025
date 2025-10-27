using Application.DTOs.Category;

namespace Application.UseCases.Brands;

public interface IGetCategoryDtoById
{
    Task<CategoryDto> Execute(long id);
}
