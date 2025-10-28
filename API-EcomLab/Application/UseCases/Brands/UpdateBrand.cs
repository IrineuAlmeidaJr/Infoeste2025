using Application.DTOs.Brand;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class UpdateBrand(
    IBrandRepository repository,
    ICacheRepository cache,
    IBrandMapper mapper) : IUpdateBrand
{
    public async Task<BrandDto> Execute(long id, BrandDto brandDto)
    {
        if (brandDto.Id != id)
            throw new NotFoundException("Marca não foi encontrada e não pôde ser atualizada");

        var brand = await repository.GetById(id);
        if (brand == null)
            throw new NotFoundException("Marca não foi encontrada e não pôde ser atualizada");

        brand.Update(brandDto.Name);
        var updatedBrand = await repository.Update(brand);

        var cacheKey = $"brand-{id}";
        await cache.RemoveCache(cacheKey);

        return mapper.ToBrandDto(updatedBrand);
    }
}

