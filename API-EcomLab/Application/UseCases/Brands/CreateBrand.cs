using Application.DTOs.Brand;
using Application.Mapper;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class CreateBrand(
    IBrandRepository repository,
    IBrandMapper mapper) : ICreateBrand
{
    public async Task<BrandDto> Execute(BrandDto brandDto)
    {
        var brand = mapper.FromBrandDto(brandDto);
        var createdBrand = await repository.Create(brand);

        return mapper.ToBrandDto(createdBrand);
    }
}

