using Domain.Exception;

namespace Domain.Entities;

public abstract class Entity<TKey>
{
    public TKey Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }
    public DateTime UpdatedAt { get; protected set; }

    protected Entity()
    {
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    protected Entity(TKey id, DateTime createdAt, DateTime updatedAt)
    {
        ValidateDomain(createdAt, updatedAt);

        Id = id;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }    

    public void UpdateTimestamps()
    {
        var updatedAt = DateTime.UtcNow;
        InvalidModelException.When(updatedAt < CreatedAt,
           "Data de atualização não pode ser anterior a Data de criação.");

        UpdatedAt = updatedAt;
    }
    private void ValidateDomain(DateTime createdAt, DateTime updatedAt)
    {
        InvalidModelException.When(createdAt == default(DateTime),
           "Data de criação inválida.");

        InvalidModelException.When(updatedAt == default(DateTime),
           "Data de atualização inválida.");

        InvalidModelException.When(updatedAt < CreatedAt,
           "Data de atualização não pode ser anterior a Data de criação.");
    }
}
