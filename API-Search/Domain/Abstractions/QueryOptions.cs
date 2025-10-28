using Domain.Enums;

namespace Domain.Abstractions;

public abstract class QueryOptions
{
    public string? OrderBy { get; set; }
    public SortDirection SortDirection { get; set; } = SortDirection.asc;
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;

    protected QueryOptions() { }

    protected QueryOptions(string orderBy, string sortDirection, 
        int page, int pageSize)
    {
        OrderBy = orderBy;
        SortDirection = Enum.TryParse<SortDirection>(orderBy, true, out var result)
            ? result
            : SortDirection.asc;
        Page = page;
        PageSize = pageSize;
    }
}