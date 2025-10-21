using Application.DTOs;
using Application.DTOs.Brand;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.Services;

public class BrandService(
    IBrandRepository repository,
    ICacheRepository cache,
    IBrandMapper mapper) : IBrandService
{
    public async Task<BrandDto> Create(BrandDto brandDto)
    {
        var brand = mapper.FromBrandDto(brandDto);
        var createdBrand = await repository.Create(brand);

        return mapper.ToBrandDto(createdBrand);
    }

    public async Task<BrandDto> Update(long id, BrandDto brandDto)
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

    public async Task Remove(long id)
    {
        var removedBrand = await repository.Remove(id);
        if (removedBrand == null)
            throw new NotFoundException("Marca não foi encontrada e não pôde ser removida");
    }

    public async Task<BrandDto> GetById(long id)
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

    public async Task<PagedResultDto<BrandDto>> GetBrandsPaged(string name, int page, int pageSize)
    {
        var brands = await repository.GetBrandsPaged(name, page, pageSize);
        if (!brands.Items.Any())
            throw new NotFoundException("Nenhuma marca foi encontrada");

        var brandsPagedResultDto = mapper.ToPagedResultDto(brands);

        return brandsPagedResultDto;
    }
}
