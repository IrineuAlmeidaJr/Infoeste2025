using Application.DTOs.Category;

namespace Application.DTO.Product;

public class ProductResponseDto
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Ean { get; set; }
    public required string Sku { get; set; }
    public int Stock { get; set; }
    public decimal BasePrice { get; set; }
    public required string ImageUrl { get; set; }

    public required string BrandName { get; set; } 
    public IEnumerable<CategoryDto>? Categories { get; set; } 
}
