using Application.DTOs.Abstractions;
using Application.DTOs.Brand;

namespace Application.Services;

public interface IBrandService
{
    Task<BrandDto> Create(BrandDto brandDto);
    Task<BrandDto> Update(long id, BrandDto brandDto);
    Task Remove(long id);
    Task<BrandDto> GetById(long id);
    Task<PagedResultDto<BrandDto>> GetBrandsPaged(string name, int page, int pageSize);
}
