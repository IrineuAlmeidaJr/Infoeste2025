using Domain.Abstractions;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class BrandRepository(ApplicationDbContext context) : IBrandRepository
{
    public async Task<Brand> Create(Brand brand)
    {
        context.Add(brand);
        await context.SaveChangesAsync();

        return brand;
    }

    public async Task<Brand> Update(Brand brand)
    {
        context.Update(brand);
        await context.SaveChangesAsync();

        return brand;
    }

    public async Task<Brand?> Remove(long id)
    {
        var stored = await GetById(id);
        if (stored == null)
            return null;

        context.Brands.Remove(stored);
        await context.SaveChangesAsync();

        return stored;
    }

    public async Task<Brand?> GetById(long id)
    {
        var stored = await context.Brands.FindAsync(id);

        return stored ?? null;
    }

    public async Task<PagedResult<Brand>> GetBrandsPaged(string? name, int page, int pageSize)
    {
        var query = context.Brands.AsQueryable();

        if (!string.IsNullOrWhiteSpace(name))
            query = query.Where(brand => EF.Functions.Like(brand.Name, $"%{name}%"));

        var totalItems = await query.CountAsync();

        var items = await query
            .OrderBy(b => b.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResult<Brand>(items, totalItems, page, pageSize);
    }
}
