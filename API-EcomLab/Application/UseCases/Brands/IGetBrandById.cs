using Domain.Entities;

namespace Application.UseCases.Brands;

public interface IGetBrandById
{
    Task<Brand> Execute(long id);
}
