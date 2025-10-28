namespace Application.DTOs;

public class PagedResultDto<T>
{
    public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
    public int TotalItems { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public long TotalPages { get; set; }
}
