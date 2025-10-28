using Application.DTOs;
using Application.DTOs.Category;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class GetCategoriesPaged(
    ICategoryRepository repository,
    ICategoryMapper mapper) : IGetCategoriesPaged
{
    public async Task<PagedResultDto<CategoryDto>> Execute(string name, int page, int pageSize)
    {
        var categories = await repository.GetCategoriesPaged(name, page, pageSize);
        if (!categories.Items.Any())
            throw new NotFoundException("Nenhuma categoria foi encontrada");

        var categoriesPagedResultDto = mapper.ToPagedResultDto(categories);

        return categoriesPagedResultDto;
    }
}
