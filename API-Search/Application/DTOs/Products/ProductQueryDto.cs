using Domain.Abstractions;

namespace Application.DTOs.Products;

public class ProductQueryDto : QueryOptions
{
    public string? Name { get; set; }
    public bool? IsOnSale { get; set; }
    public double PriceMin { get; set; }
    public double PriceMax { get; set; }
}
