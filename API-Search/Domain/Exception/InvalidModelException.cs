using System.Net;

namespace Domain.Exception;

public class InvalidModelException : DomainException
{
    private const string DefaultTitle = "Dados inválidos";

    public InvalidModelException(string description)
        : base(DefaultTitle, description, HttpStatusCode.UnprocessableEntity)
    {
    }

    public static void When(bool hasError, string description)
    {
        if (hasError)
            throw new InvalidModelException(description);
    }
}