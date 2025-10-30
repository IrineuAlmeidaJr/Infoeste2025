using Application.Services;
using Confluent.Kafka;
using Domain.Entities;
using Domain.Event;
using Infrastructure.Configuration.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Incoming.Messaging;

public class UpdateProductKafkaListener(
    IKafkaContext context,
    IConfiguration configuration,
    IProductService productService,
    ILogger<UpdateProductKafkaListener> logger) 
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
        logger.LogInformation($"[{DateTime.UtcNow}][UpdateProductKafkaListener] Inicialicou de atualização do produto");

        var value = message.Value;
        await productService.Update(value);
       
        logger.LogInformation($"[{DateTime.UtcNow}][UpdateProductKafkaListener] Finalizou de atualização do produto");
    }
}
