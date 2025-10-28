using Application.DTOs;
using Application.DTOs.Category;
using Application.UseCases.Brands;

namespace Application.Services;

public class CategoryService(
    ICreateCategory createCategory,
    IUpdateCategory updateCategory,
    IRemoveCategory removeCategory,
    IGetCategoryDtoById getCategoryById,
    IGetCategoriesPaged getCategoriesPaged) : ICategoryService
{
    public async Task<CategoryDto> Create(CategoryDto categoryDto)
    {
        return await createCategory.Execute(categoryDto);
    }

    public async Task<CategoryDto> Update(long id, CategoryDto categoryDto)
    {
        return await updateCategory.Execute(id, categoryDto);
    }

    public async Task Remove(long id)
    {
        await removeCategory.Execute(id);
    }

    public async Task<CategoryDto> GetById(long id)
    {
        return await getCategoryById.Execute(id);
    }

    public async Task<PagedResultDto<CategoryDto>> GetCategoriesPaged(string name, int page, int pageSize)
    {
        return await getCategoriesPaged.Execute(name, page, pageSize);
    }
}
