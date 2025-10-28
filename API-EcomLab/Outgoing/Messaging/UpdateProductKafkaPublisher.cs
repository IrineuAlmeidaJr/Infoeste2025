using Application.Event;
using Confluent.Kafka;
using Domain.Entities;
using Domain.Event;
using Infrastructure.Configuration.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Outgoing.Messaging;
public class UpdateProductKafkaPublisher : KafkaBaseProducer<Ignore, KafkaEvent<ProductEvent>>, IUpdateProductEventPublisher
{
    public UpdateProductKafkaPublisher(
        IKafkaContext context,
        IConfiguration configuration,
        ILogger<UpdateProductKafkaPublisher> logger)
        : base(context, logger, configuration.GetValue<string>("Kafka:Topics:UpdateProduct") ?? "api-search.product-update")
    {

    }
}
