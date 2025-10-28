using Domain.Entities;
using Domain.Event;

namespace Application.Event;

public interface IUpdateProductEventPublisher
{
    Task PublishAsync(KafkaEvent<ProductEvent> payload);
}
