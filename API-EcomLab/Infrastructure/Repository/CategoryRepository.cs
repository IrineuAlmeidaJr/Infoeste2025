using Domain.Abstractions;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Nest;

namespace Infrastructure.Repository;

public class CategoryRepository(ApplicationDbContext context) : ICategoryRepository
{
    public async Task<Category> Create(Category category)
    {
        context.Add(category);
        await context.SaveChangesAsync();

        return category;
    } 

    public async Task<Category> Update(Category category)
    {
        context.Update(category);
        await context.SaveChangesAsync();

        return category;
    }

    public async Task<Category?> Remove(long id)
    {
        var stored = await GetById(id);
        if (stored == null)
            return null;

        context.Categories.Remove(stored);
        await context.SaveChangesAsync();

        return stored;
    }

    public async Task<Category?> GetById(long id)
    {
        var stored = await context.Categories.FindAsync(id);

        return stored ?? null;
    }

    public async Task<PagedResult<Category>> GetCategoriesPaged(string? name, int page, int pageSize)
    {
        var query = context.Categories.AsQueryable();

        if (!string.IsNullOrWhiteSpace(name))
            query = query.Where(category => EF.Functions.Like(category.Name, $"%{name}%"));

        var totalItems = await query.CountAsync();

        var items = await query
            .OrderBy(b => b.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResult<Category>(items, totalItems, page, pageSize);
    }
}
