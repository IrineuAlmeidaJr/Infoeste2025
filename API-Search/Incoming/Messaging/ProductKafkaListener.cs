using Application.Services;
using Confluent.Kafka;
using Domain.Entities;
using Domain.Event;
using Infrastructure.Configuration.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Incoming.Messaging;

public class ProductKafkaListener(
    IKafkaContext context,
    IConfiguration configuration,
    IProductService productService,
    ILogger<ProductKafkaListener> logger) 
    : 
    KafkaBaseConsumer<Ignore, KafkaEvent<Product>>(
        context,
        logger,
        configuration.GetValue<string>("Kafka:Topics:CreateProduct")
        ?? "api-search.product-create"
    )
{

    protected override async Task HandleMessage(Message<Ignore, KafkaEvent<Product>> message)
    {
        logger.LogInformation($"[{DateTime.UtcNow}][ProductKafkaListener] Inicialicou de atualização do Status");

        var value = message.Value;
        await productService.Create(value);
       
        logger.LogInformation($"[{DateTime.UtcNow}][ProductKafkaListener] Finalizou de atualização do Status");
    }
}
