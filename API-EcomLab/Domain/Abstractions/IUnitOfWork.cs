namespace Domain.Abstractions;

public interface IUnitOfWork
{
    Task<ITransaction> BeginTransactionAsync();
}
