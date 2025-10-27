using Application.DTOs.Brand;

namespace Application.UseCases.Brands;

public interface ICreateBrand
{
    Task<BrandDto> Execute(BrandDto brandDto);
}
