using Application.DTOs;
using Application.DTOs.Brand;
using Application.Mapper;
using Domain.Exception;
using Domain.Repository;

namespace Application.UseCases.Brands;

public class GetBrandsPaged(
    IBrandRepository repository,
    ICacheRepository cache,
    IBrandMapper mapper) : IGetBrandsPaged
{
    public async Task<PagedResultDto<BrandDto>> Execute(string name, int page, int pageSize)
    {
        var brands = await repository.GetBrandsPaged(name, page, pageSize);
        if (!brands.Items.Any())
            throw new NotFoundException("Nenhuma marca foi encontrada");

        var brandsPagedResultDto = mapper.ToPagedResultDto(brands);

        return brandsPagedResultDto;
    }
}
