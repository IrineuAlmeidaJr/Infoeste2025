using Domain.Enums;

namespace Domain.Abstractions;

public abstract class QueryOptions
{
    public string? OrderBy { get; set; }
    public SortDirection SortDirection { get; set; } = SortDirection.Asc;
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}