using Domain.Entities;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class GetBrandById(
    IBrandRepository repository) : IGetBrandById
{
    public async Task<Brand> Execute(long id)
    {
        var brand = await repository.GetById(id);
        if (brand == null)
            throw new NotFoundException("Marca não foi encontrada");

        return brand;
    }
}

