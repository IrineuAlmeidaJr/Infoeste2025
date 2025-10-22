using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Repository;

public interface IProductRepository
{
    Task<Product> Create(Product product);
    Task<Product> Update(Product product);
    Task<Product?> Remove(long id);
    Task<Product?> GetById(long id);
    Task<PagedResult<Product>> GetProductsPaged(string? name, int page, int pageSize);
}
