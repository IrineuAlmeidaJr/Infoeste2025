using Application.DTOs.Product;
using Domain.Entities;
using Nest;

namespace Infrastructure.Repository.Elastic;

public interface IElasticProduct
{
    Task Create(Product product);
    Task Update(Product product);
    Task<Product?> GetProductByProductId(long productId);
    Task<ISearchResponse<Product>> SearchCampaignsAsync(ProductQueryDto productQueryDto);
}
