using Domain.Exception;

namespace Domain.Entities;

public sealed class Product : Entity<long>
{
    public string? Name { get; private set; }
    public string? Description { get; private set; }
    public string? Ean { get; private set; }
    public string? Sku { get; private set; }
    public int Stock { get; private set; }
    public decimal BasePrice { get; private set; }
    public string? ImageUrl { get; private set; }


    public long BrandId { get; set; }
    public Brand Brand { get; set; }

    public ICollection<Category> Categories { get; set; } = new List<Category>();

    public Product(string name, string description, string ean, string sku, int stock, decimal basePrice, string imageUrl)
    {
        ValidateDomain(name, description, ean, sku, stock, basePrice, imageUrl);
    }

    public Product(string name, string description, string ean, string sku, int stock, decimal basePrice, string imageUrl,
        long id, DateTime createdAt, DateTime updatedAt)
        : base(id, createdAt, updatedAt)
    {
        ValidateDomain(name, description, ean, sku, stock, basePrice, imageUrl);
    }

    public Product(string name, string description, string ean, string sku, int stock, decimal basePrice, string imageUrl,
        long id, DateTime createdAt, DateTime updatedAt, long brandId, Brand brand, ICollection<Category> categories)
        : base(id, createdAt, updatedAt)
    {
        ValidateDomain(name, description, ean, sku, stock, basePrice, imageUrl);
        BrandId = brandId;
        Brand = brand;
        Categories = categories;
    }

    public void Update(string name, string description, string ean, string sku, int stock, decimal basePrice, string imageUrl)
    {
        ValidateDomain(name, description, ean, sku, stock, basePrice, imageUrl);
        base.UpdateTimestamps();
    }

    private void ValidateDomain(string name, string description, string ean, string sku, int stock, decimal basePrice, string imageUrl)
    {
        // Name
        InvalidModelException.When(string.IsNullOrEmpty(name),
            "Nome inválido. O campo 'Nome' é obrigatório.");

        InvalidModelException.When(name.Length < 3,
            "Nome muito curto. O mínimo é de 3 caracteres.");

        InvalidModelException.When(name.Length > 150,
            "Nome muito grande. O máximo é de 150 caracteres.");

        // Description
        if (!string.IsNullOrEmpty(description))
        {
            InvalidModelException.When(description.Length < 20,
                "Descrição muito curto. O mínimo é de 20 caracteres.");

            InvalidModelException.When(name.Length > 4000,
                "Descrição muito grande. O máximo é de 4000 caracteres.");
        }

        // EAN
        InvalidModelException.When(string.IsNullOrEmpty(ean),
           "EAN inválido. O campo 'EAN' é obrigatório.");

        InvalidModelException.When(!(ean.Length == 8 || ean.Length == 13),
            "EAN deve ter 8 ou 13 dígitos.");

        // SKU
        InvalidModelException.When(string.IsNullOrEmpty(sku),
           "SKU inválido. O campo 'SKU' é obrigatório.");

        InvalidModelException.When(sku.Length > 20,
            "SKU deve ter no máximo 20 caracteres.");

        // Stock
        InvalidModelException.When(stock < 0,
            "Valor de estoque inválido.");

        // Base Price
        InvalidModelException.When(basePrice < 0,
           "Valor de base do produto inválido.");

        // ImageUrl
        InvalidModelException.When(!string.IsNullOrEmpty(imageUrl) && imageUrl.Length > 2500,
                "Url da Imagem muito grande. O máximo é de 2500 caracteres.");

        Name = name;
        Description = description;
        Ean = ean;
        Sku = sku;
        Stock = stock;
        BasePrice = basePrice;
        ImageUrl = imageUrl;
    }
}
