using Application.DTOs;
using Application.DTOs.Brand;
using Application.UseCases.Brands;

namespace Application.Services;

public class BrandService(
    ICreateBrand createBrand,
    IUpdateBrand updateBrand,
    IRemoveBrand removeBrand,
    IGetBrandDtoById getBrandById,
    IGetBrandsPaged getBrandsPaged) : IBrandService
{
    public async Task<BrandDto> Create(BrandDto brandDto)
    {
        return await createBrand.Execute(brandDto);
    }

    public async Task<BrandDto> Update(long id, BrandDto brandDto)
    {
        return await updateBrand.Execute(id, brandDto);
    }

    public async Task Remove(long id)
    {
        await removeBrand.Execute(id);
    }

    public async Task<BrandDto> GetById(long id)
    {
        return await getBrandById.Execute(id);
    }

    public async Task<PagedResultDto<BrandDto>> GetBrandsPaged(string name, int page, int pageSize)
    {
        return await getBrandsPaged.Execute(name, page, pageSize);
    }
}
