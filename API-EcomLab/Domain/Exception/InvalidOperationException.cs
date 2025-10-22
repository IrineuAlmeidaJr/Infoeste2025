using System.Net;

namespace Domain.Exception;

public class InvalidOperationException : DomainException
{
    private const string DEFAULT_TITLE = "Operação inválida";
    public InvalidOperationException(string description)
        : base(DEFAULT_TITLE, description, HttpStatusCode.Conflict)
    {
    }

    public InvalidOperationException(string title, string description)
       : base(title, description, HttpStatusCode.Conflict)
    {
    }
}
