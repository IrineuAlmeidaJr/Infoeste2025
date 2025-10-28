namespace Application.UseCases.Brands;

public interface IRemoveCategory
{
    Task Execute(long id);
}
