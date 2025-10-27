using Application.DTOs.Brand;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class GetBrandDtoById(
    IBrandRepository repository,
    ICacheRepository cache,
    IBrandMapper mapper) : IGetBrandDtoById
{
    public async Task<BrandDto> Execute(long id)
    {
        var cacheKey = $"brand-{id}";
        var cachedBrandDto = await cache.ReadCache<BrandDto>(cacheKey);

        if (cachedBrandDto != null)
            return cachedBrandDto;

        var brand = await repository.GetById(id);
        if (brand == null)
            throw new NotFoundException("Marca não foi encontrada");

        var brandDto = mapper.ToBrandDto(brand);
        await cache.SaveCache(cacheKey, brandDto);

        return brandDto;
    }
}

