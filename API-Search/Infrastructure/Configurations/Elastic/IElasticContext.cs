using Nest;

namespace Infrastructure.Configuration.Elastic;

public interface IElasticContext
{
    IElasticClient Get();
}
