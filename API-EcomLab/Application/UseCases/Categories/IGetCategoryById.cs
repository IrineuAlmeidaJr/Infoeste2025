using Domain.Entities;

namespace Application.UseCases.Categories;

public interface IGetCategoryById
{
    Task<Category> Execute(long id);
}
