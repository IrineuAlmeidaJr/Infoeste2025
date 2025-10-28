namespace Application.UseCases.Products;

public interface IRemoveProduct
{
    Task Execute(long id);
}
