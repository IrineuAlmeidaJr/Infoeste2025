using Application.Mapper;
using Domain.Entities;
using Domain.Event;
using Domain.Repository;

namespace Application.Services;

public class ProductService(
    IProductRepository repository,
    ICacheRepository cache,
    IProductMapper mapper) : IProductService
{
    public async Task Create(KafkaEvent<Product> productEvent)
    {
        var product = mapper.FromKafkaProductEvent(productEvent);

        await repository.Create(product);
    }

    public Task Update(KafkaEvent<Product> productEvent)
    {
        throw new NotImplementedException();
    }
}
