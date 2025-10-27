using Application.DTOs;
using Application.DTOs.Brand;

namespace Application.UseCases.Brands;

public interface IGetBrandsPaged
{
    Task<PagedResultDto<BrandDto>> Execute(string name, int page, int pageSize);
}
