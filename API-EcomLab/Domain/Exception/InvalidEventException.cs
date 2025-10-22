using System.Net;
using Domain.Exception;

namespace Domain.Exceptions;

public class InvalidEventException : DomainException
{
    private const string DefaultTitle = "Evento inválido";

    public InvalidEventException(string description)
        : base(DefaultTitle, description, HttpStatusCode.UnprocessableEntity)
    {
    }
}