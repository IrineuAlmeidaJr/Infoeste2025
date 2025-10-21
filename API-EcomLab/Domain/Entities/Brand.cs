using System.Text.Json.Serialization;
using Domain.Exception;

namespace Domain.Entities;

public sealed class Brand : Entity<long>
{
    public string? Name { get; private set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();

    public Brand(string name)
    {
        ValidateDomain(name);
    }

    public Brand(long id, string name, DateTime createdAt, DateTime updatedAt)
        : base(id, createdAt, updatedAt)
    {
        InvalidModelException.When(id < 0, "Id inválida.");

        ValidateDomain(name);
    }

    [JsonConstructor]
    public Brand(long id, string name, DateTime createdAt, DateTime updatedAt, ICollection<Product> products)
        : base(id, createdAt, updatedAt)
    {
        InvalidModelException.When(id < 0, "Id inválida.");

        ValidateDomain(name);
        Products = products;
    }

    public void Update(string name)
    {
        ValidateDomain(name);
        base.UpdateTimestamps();
    }

    private void ValidateDomain(string name)
    {
        InvalidModelException.When(string.IsNullOrEmpty(name),
            "Nome inválido. O campo 'Nome' é obrigatório.");

        InvalidModelException.When(name.Length < 3,
            "Nome muito curto. O mínimo é de 3 caracteres.");

        InvalidModelException.When(name.Length > 150,
            "Nome muito grande. O máximo é de 150 caracteres.");

        Name = name;
    }
}