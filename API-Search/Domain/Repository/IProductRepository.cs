using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Repository;

public interface IProductRepository
{
    Task Create(Product product);
    Task Update(Product product);
    Task<Product?> GetById(Guid id);
    Task<PagedResult<Product>> GetProductsPaged(QueryOptions queryOptions);
}
