using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Repository;

public interface ICategoryRepository
{
    Task<Category> Create(Category category);
    Task<Category> Update(Category category);
    Task<Category?> Remove(long id);
    Task<Category?> GetById(long id);
    Task<PagedResult<Category>> GetCategoriesPaged(string? name, int page, int pageSize);
}
    