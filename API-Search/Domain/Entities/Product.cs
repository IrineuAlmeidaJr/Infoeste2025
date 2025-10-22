namespace Domain.Entities;

public sealed class Product
{
    public Guid Id { get; set; }
    public long ProductId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Ean { get; set; }
    public required string Sku { get; set; }
    public bool InStock { get; set; }
    public decimal BasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public bool IsOnSale { get; set; }
    public DateTime OnSaleEnd { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? ImageUrl { get; set; }
    public required string Brand { get; set; }
    public ICollection<string> Categories { get; set; } = new List<string>();
    public bool IsActive { get; set; }
}
