using Application.DTOs.Products;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Configuration.Elastic;
using Microsoft.Extensions.Logging;
using Nest;
using Newtonsoft.Json;

namespace Infrastructure.Repository.Elastic;

public class ElasticProduct(
    ILogger<ElasticProduct> logger,
    IElasticContext elasticContext) : IElasticProduct
{
    private const string IndexName = "product-infoeste-irineu";

    public async Task Create(Product product)
    {
        var productExists = await GetProductByProductId(product.ProductId) != null;
        if (productExists)
        {
            var productJson = JsonConvert.SerializeObject(product);
            logger.LogInformation($"[ElasticProduct] [Create] Duplicidade de produto. " +
                $"Existe uma produto com mesmo productId: {product.Id}. Json: '{productJson}'");
            return;
        }

        var response = await elasticContext
            .Get()
            .IndexAsync(product, indexDescriptor => indexDescriptor
                .Index(IndexName)
            );

        if (!response.IsValid)
            throw new Exception($"Erro ao salvar produto no Elasticsearch: {response.ServerError?.Error.Reason}");
    }

    public async Task Update(Product product)
    {
        var stored = await GetProductByProductId(product.ProductId);
        if (stored == null)
        {
            var productJson = JsonConvert.SerializeObject(product);
            logger.LogInformation($"[ElasticProduct] [Update] Não conseguiu localizar produto com productId: {product.Id}. " +
                $"Json: '{productJson}'");
            return;
        }

        var response = await elasticContext
            .Get()
            .UpdateAsync<Product>(stored, updateDescriptor => updateDescriptor
                .Index(IndexName)
                .Doc(product)
            );

        if (!response.IsValid)
            throw new Exception($"Erro ao editar produto no Elasticsearch: {response.ServerError?.Error.Reason}");
    }

    public async Task<Product?> GetProductByProductId(long productId)
    {
        var response = await elasticContext.Get()
            .SearchAsync<Product>(searchDescriptor => searchDescriptor
                .Index(IndexName)
                .Query(query => query
                    .Term(term => term
                        .Field(field => field.ProductId)
                        .Value(productId)
                    )
                )
                .Size(1)
            );

        if (!response.IsValid || !response.Documents.Any())
            return null;

        return response.Documents.First();
    }

    public async Task<ISearchResponse<Product>> SearchCampaignsAsync(ProductQueryDto productQueryDto)
    {
        var query = BuildQuery(productQueryDto);

        var descriptor = new SearchDescriptor<Product>()
            .Index(IndexName)
            .Query(q => query)
            .From((productQueryDto.Page - 1) * productQueryDto.PageSize)
            .Size(productQueryDto.PageSize);

        if (!string.IsNullOrWhiteSpace(productQueryDto.OrderBy))
        {
            descriptor = descriptor.Sort(s => AddSort(productQueryDto.OrderBy, productQueryDto.SortDirection, s));
        }

        var response = await elasticContext.Get().SearchAsync<Product>(descriptor);

        return response;
    }


    private QueryContainer BuildQuery(ProductQueryDto productQueryDto)
    {
        var mustQueries = new List<QueryContainer>();

        mustQueries.Add(new TermQuery
        {
            Field = Infer.Field<Product>(product => product.IsActive),
            Value = true
        });

        // Filtro por nome (se fornecido)
        if (!string.IsNullOrWhiteSpace(productQueryDto.Name))
        {
            mustQueries.Add(new MatchQuery
            {
                Field = Infer.Field<Product>(product => product.Name),
                Query = productQueryDto.Name
            });
        }

        // Filtro por produto em promoção
        if (productQueryDto.IsOnSale.HasValue)
        {
            mustQueries.Add(new TermQuery
            {
                Field = Infer.Field<Product>(product => product.IsOnSale),
                Value = productQueryDto.IsOnSale.Value
            });
        }

        // Filtro por preço mínimo
        if (productQueryDto.PriceMin > 0)
        {
            mustQueries.Add(new NumericRangeQuery
            {
                Field = Infer.Field<Product>(product => product.BasePrice),
                GreaterThanOrEqualTo = productQueryDto.PriceMin
            });
        }

        // Filtro por preço máximo
        if (productQueryDto.PriceMax > 0)
        {
            mustQueries.Add(new NumericRangeQuery
            {
                Field = Infer.Field<Product>(product => product.BasePrice),
                LessThanOrEqualTo = productQueryDto.PriceMax
            });
        }

        return new QueryContainerDescriptor<Product>()
            .Bool(b => b.Must(mustQueries.ToArray()));
    }

    private SortDescriptor<Product> AddSort(string orderBy, SortDirection direction, SortDescriptor<Product> sort)
    {
        if (string.IsNullOrWhiteSpace(orderBy))
            return sort;

        var isAsc = direction == SortDirection.Asc;

        return orderBy.ToLower() switch
        {
            "name" => isAsc
                ? sort.Ascending(filter => filter.Name.Suffix("keyword"))
                : sort.Descending(filter => filter.Name.Suffix("keyword")
            ),
            "price" => isAsc
                ? sort.Ascending(filter => filter.IsOnSale
                    ? filter.SalePrice
                    : filter.BasePrice)
                : sort.Descending(filter => filter.IsOnSale
                    ? filter.SalePrice
                    : filter.BasePrice),
            _ => sort
        };
    }

}
