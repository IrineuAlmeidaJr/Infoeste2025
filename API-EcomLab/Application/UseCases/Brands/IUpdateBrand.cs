using Application.DTOs.Brand;

namespace Application.UseCases.Brands;

public interface IUpdateBrand
{
    Task<BrandDto> Execute(long id, BrandDto brandDto);
}
