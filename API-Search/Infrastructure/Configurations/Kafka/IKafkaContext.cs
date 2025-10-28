using Confluent.Kafka;

namespace Infrastructure.Configuration.Kafka;

public interface IKafkaContext
{
    ConsumerConfig GetConsumerConfig();
    ProducerConfig GetProducerConfig();
}