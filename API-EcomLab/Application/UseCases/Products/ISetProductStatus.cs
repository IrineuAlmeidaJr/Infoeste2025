namespace Application.UseCases.Products;

public interface ISetProductStatus
{
    Task Execute(long id);
}
