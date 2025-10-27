using Application.DTOs;
using Application.DTOs.Category;

namespace Application.UseCases.Brands;

public interface IGetCategoriesPaged
{
    Task<PagedResultDto<CategoryDto>> Execute(string name, int page, int pageSize);
}
