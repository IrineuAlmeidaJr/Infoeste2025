using Domain.Abstractions;
using Domain.Entities;
using Domain.Repository;

namespace Infrastructure.Repository;

public class ProductRepository(ApplicationDbContext context) : IProductRepository
{
    public async Task<Product> Create(Product product)
    {
        context.Add(product);
        await context.SaveChangesAsync();

        return product;
    }

    public async Task<Product> Update(Product product)
    {
        context.Update(product);
        await context.SaveChangesAsync();

        return product;
    }

    public async Task<Product?> Remove(long id)
    {
        var stored = await GetById(id);
        if (stored == null)
            return null;

        context.Products.Remove(stored);
        await context.SaveChangesAsync();
        return stored;
    }

    public async Task<Product?> GetById(long id)
    {
        var stored = await context.Products
            .Include(p => p.Brand)
            .Include(p => p.Categories)
            .FirstOrDefaultAsync(p => p.Id == id);

        return stored ?? null;
    }

    public async Task<PagedResult<Product>> GetProductsPaged(string? name, int page, int pageSize)
    {
        var query = context.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(name))
            query = query.Where(product => EF.Functions.Like(product.Name, $"%{name}%"));

        var totalItems = await query.CountAsync();

        var items = await query
            .Include(p => p.Brand)
            .Include(p => p.Categories)
            .OrderBy(b => b.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResult<Product>(items, totalItems, page, pageSize);
    }
}
