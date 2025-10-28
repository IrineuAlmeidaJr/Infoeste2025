using Domain.Entities;
using Domain.Event;

namespace Application.Event;

public interface ICreateProductEventPublisher
{
    Task PublishAsync(KafkaEvent<ProductEvent> payload);
}
