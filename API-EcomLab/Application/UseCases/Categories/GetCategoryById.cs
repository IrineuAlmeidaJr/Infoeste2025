using Domain.Entities;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Categories;

public class GetCategoryById(ICategoryRepository repository) : IGetCategoryById
{
    public async Task<Category> Execute(long id)
    {
        var category = await repository.GetById(id);
        if (category == null)
            throw new NotFoundException("Categoria não foi encontrada");

        return category;
    }
}