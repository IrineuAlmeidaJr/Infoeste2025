using Application.DTOs.Product;
using Domain.Abstractions;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Repository.Elastic;

namespace Infrastructure.Repository;

public class ProductRepository(
    IElasticProduct elasticProduct) : IProductRepository
{
    public async Task Create(Product product)
    {
        await elasticProduct.Create(product);
    }

    public async Task Update(Product product)
    {
        await elasticProduct.Update(product);
    }

    public async Task<Product?> GetById(long id)
    {
        return await elasticProduct.GetProductByProductId(id);
    }

    public async Task<PagedResult<Product>> GetProductsPaged(QueryOptions queryOptions)
    {
        var query = queryOptions as ProductQueryDto
            ?? throw new ArgumentException("Parâmetros de consulta inválidos.");

        var response = await elasticProduct.SearchCampaignsAsync(query);
        var pagedResult = new PagedResult<Product>(response.Documents, response.Total, query.Page, query.PageSize);

        return pagedResult;
    }
}
