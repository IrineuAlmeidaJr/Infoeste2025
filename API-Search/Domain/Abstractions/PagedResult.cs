namespace Domain.Abstractions;

public class PagedResult<T>
{
    public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
    public long TotalItems { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }

    public PagedResult() { }

    public PagedResult(IEnumerable<T> items, long totalItems, int pageNumber, int pageSize)
    {
        Items = items;
        TotalItems = totalItems;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
    }
}
