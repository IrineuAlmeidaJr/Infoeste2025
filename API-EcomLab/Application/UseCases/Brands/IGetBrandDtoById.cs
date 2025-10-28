using Application.DTOs.Brand;

namespace Application.UseCases.Brands;

public interface IGetBrandDtoById
{
    Task<BrandDto> Execute(long id);
}
