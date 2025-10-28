namespace Domain.Event;

public class KafkaEvent<T>
{
    public Guid Id { get; set; }
    public required string Type { get; set; } 
    public required string Version { get; set; } 
    public required string Source { get; set; } 
    public DateTime OccurredAt { get; set; }
    public required string Topic { get; set; }
    public required T Data { get; set; }
}
