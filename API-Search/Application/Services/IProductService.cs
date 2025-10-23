using Domain.Entities;
using Domain.Event;

namespace Application.Services;

public interface IProductService
{
    Task Create(KafkaEvent<Product> productEvent);
    Task Update(KafkaEvent<Product> productEvent);
    //Task<ProductResponseDto> GetById(long id);
    //Task<PagedResultDto<ProductResponseDto>> GetProductsPaged(string name, int page, int pageSize);
}
