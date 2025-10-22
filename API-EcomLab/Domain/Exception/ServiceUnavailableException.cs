using System.Net;

namespace Domain.Exception;

[Serializable]
public class ServiceUnavailableException : DomainException
{
    public ServiceUnavailableException()
        : base("Serviço Indisponível", "O serviço está temporariamente indisponível. Por favor, tente novamente mais tarde.", HttpStatusCode.ServiceUnavailable)
    {
    }

    public ServiceUnavailableException(string description)
        : base("Serviço indisponível", description, HttpStatusCode.ServiceUnavailable)
    {
    }

    public ServiceUnavailableException(string title, string description)
        : base(title, description, HttpStatusCode.ServiceUnavailable)
    {
    }
}
