namespace Application.DTOs.Product;

public class ProductCreateDto
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Ean { get; set; }
    public required string Sku { get; set; }
    public int Stock { get; set; }
    public decimal BasePrice { get; set; }
    public required string ImageUrl { get; set; }

    public long BrandId { get; set; }
    public IEnumerable<long> CategoryIds { get; set; } = new List<long>();
}
