using Application.DTOs.Abstractions;
using Application.DTOs.Brand;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Mapper;

public interface IBrandMapper
{
    Brand FromBrandDto(BrandDto brandDto);
    BrandDto ToBrandDto(Brand brand);
    PagedResultDto<BrandDto> ToPagedResultDto(PagedResult<Brand> pagedResult);
}
