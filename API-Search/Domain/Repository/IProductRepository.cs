using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Repository;

public interface IProductRepository
{
    Task Create(Product product);
    Task Update(Product product);;
    Task<Product?> GetById(long id);
    Task<PagedResult<Product>> GetProductsPaged(string? name, int page, int pageSize);
}
