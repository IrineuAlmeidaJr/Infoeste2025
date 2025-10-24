using Domain.Abstractions;

namespace Application.DTOs.Products;

public class ProductQueryDto : QueryOptions
{
    public string? Name { get; set; }
    public bool? IsOnSale { get; set; }
    public double PriceMin { get; set; }
    public double PriceMax { get; set; }

    public ProductQueryDto(int page, int pageSize, string name,
        string orderBy, string sortDirection, bool isOnSale, double priceMin, double priceMax)
        : base(orderBy, sortDirection, page, pageSize)
    {
        Name = name;
        IsOnSale = isOnSale;
        PriceMin = priceMin;
        PriceMax = priceMax;
    }
}
