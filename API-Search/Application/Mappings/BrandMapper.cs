using Application.DTOs.Abstractions;
using Application.DTOs.Brand;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Mapper;

public class BrandMapper : IBrandMapper
{
    public Brand FromBrandDto(BrandDto brandDto) => new Brand(brandDto.Name);

    public BrandDto ToBrandDto(Brand brand) => new BrandDto()
    {
        Id = brand.Id,
        Name = brand.Name
    };

    public PagedResultDto<BrandDto> ToPagedResultDto(PagedResult<Brand> pagedResult) => new PagedResultDto<BrandDto>()
    {
        Items = pagedResult.Items.Select(ToBrandDto).ToList(),
        TotalItems = pagedResult.TotalItems,
        PageNumber = pagedResult.PageNumber,
        PageSize = pagedResult.PageSize,
        TotalPages = pagedResult.TotalPages
    };
}
