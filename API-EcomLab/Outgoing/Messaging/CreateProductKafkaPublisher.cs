using Application.Event;
using Confluent.Kafka;
using Domain.Entities;
using Domain.Event;
using Infrastructure.Configuration.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Outgoing.Messaging;
public class CreateProductKafkaPublisher : KafkaBaseProducer<Ignore, KafkaEvent<ProductEvent>>, ICreateProductEventPublisher
{
    public CreateProductKafkaPublisher(
        IKafkaContext context,
        IConfiguration configuration,
        ILogger<CreateProductKafkaPublisher> logger)
        : base(context, logger, configuration.GetValue<string>("Kafka:Topics:CreateProduct") ?? "api-search.product-create")
    {

    }
}
