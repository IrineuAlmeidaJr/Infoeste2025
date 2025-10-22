using Confluent.Kafka;
using System.Text;
using System.Text.Json;

namespace Infrastructure.Configuration.Kafka;

public class KafkaJsonSerializer<T> : ISerializer<T>, IDeserializer<T>
{
    public byte[] Serialize(T data, SerializationContext context)
    {
        return JsonSerializer.SerializeToUtf8Bytes(data);
    }

    public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        if (isNull || data.IsEmpty)
        {
            return default!;
        }

        var json = Encoding.UTF8.GetString(data);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<T>(json, options)!;
    }
}