namespace Application.UseCases.Brands;

public interface IRemoveBrand
{
    Task Execute(long id);
}
