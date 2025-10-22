using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Repository;

public interface IBrandRepository
{
    Task<Brand> Create(Brand brand);
    Task<Brand> Update(Brand brand);
    Task<Brand?> Remove(long id);
    Task<Brand?> GetById(long id);
    Task<PagedResult<Brand>> GetBrandsPaged(string? name, int page, int pageSize);
}
    