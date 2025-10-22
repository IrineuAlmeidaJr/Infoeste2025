using System.Net;

namespace Domain.Exception;

public class NotFoundException : DomainException
{
    private const string DefaultTitle = "Recurso não encontrado";

    public NotFoundException(string description)
        : base(DefaultTitle, description, HttpStatusCode.NotFound)
    {
    }
}