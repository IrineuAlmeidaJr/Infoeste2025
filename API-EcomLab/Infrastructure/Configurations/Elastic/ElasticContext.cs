using Microsoft.Extensions.Configuration;
using Nest;

namespace Infrastructure.Configuration.Elastic;

public class ElasticContext : IElasticContext
{
    private readonly IElasticClient _elasticClient;

    public ElasticContext(IConfiguration configuration)
    {
        var settings = new ConnectionSettings(new Uri(configuration.GetValue<string>("Elastic:Url")));
        settings.BasicAuthentication(configuration.GetValue<string>("Elastic:Username"), configuration.GetValue<string>("Elastic:Password"));

        _elasticClient = new ElasticClient(settings);
    }

    public IElasticClient Get()
    {
        return _elasticClient;
    }
}
