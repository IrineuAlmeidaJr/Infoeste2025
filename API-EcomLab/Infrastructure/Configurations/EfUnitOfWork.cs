using Domain.Abstractions;
using Infrastructure.Context;

namespace Infrastructure.Configurations;

public class EfUnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
{
    public async Task<ITransaction> BeginTransactionAsync()
    {
        var efTransaction = await dbContext.Database.BeginTransactionAsync();
        return new EfTransaction(efTransaction); 
    }
}
