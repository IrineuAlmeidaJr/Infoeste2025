using Application.DTOs.Abstractions;

namespace Application.DTOs.Product;

public class ProductQueryDto : QueryOptionsDto
{
    public string? Name { get; set; }
    public bool? IsOnSale { get; set; }
    public double PriceMin { get; set; }
    public double PriceMax { get; set; }
}
