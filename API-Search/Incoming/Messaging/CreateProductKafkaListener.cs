using Application.Services;
using Confluent.Kafka;
using Domain.Entities;
using Domain.Event;
using Infrastructure.Configuration.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Incoming.Messaging;

public class CreateProductKafkaListener(
    IKafkaContext context,
    IConfiguration configuration,
    IProductService productService,
    ILogger<CreateProductKafkaListener> logger) 
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
        logger.LogInformation($"[{DateTime.UtcNow}][CreateProductKafkaListener] Inicialicou criação de produto");

        var value = message.Value;
        await productService.Create(value);
       
        logger.LogInformation($"[{DateTime.UtcNow}][CreateProductKafkaListener] Finalizou criação de produto");
    }
}
