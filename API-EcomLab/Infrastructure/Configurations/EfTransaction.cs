using Microsoft.EntityFrameworkCore.Storage;
using Domain.Abstractions;

namespace Infrastructure.Configurations;

public class EfTransaction(IDbContextTransaction efTransaction) : ITransaction
{
    public Task CommitAsync() => efTransaction.CommitAsync();
    public Task RollbackAsync() => efTransaction.RollbackAsync();
    public ValueTask DisposeAsync() => efTransaction.DisposeAsync();
}
