using Infrastructure.Configurations;
using Serilog;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();

        //register services  
        RegistryInfrastructureServices(builder);
        RegistryDomainServices(builder);
        RegistryApplicationServices(builder);
        RegistryIncomingServices(builder);
        RegistryOutgoingServices(builder);

        builder.Services.AddControllers();
        builder.Services.AddHttpClient();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Host.UseSerilog();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseMiddleware<ExceptionHandler>();

        app.UseAuthorization();
        app.MapControllers();
        app.UseHttpsRedirection();

        ExecuteInitializationServices(app);

        app.Run();
    }

    private static void ExecuteInitializationServices(WebApplication app)
    {
        //app.Services.GetRequiredService<IElasticContext>();
        //app.Services.GetRequiredService<IRedisContext>();
        //app.Services.GetRequiredService<IKafkaContext>();
    }

    private static void RegistryApplicationServices(WebApplicationBuilder builder)
    {
        // mappers
        //builder.Services.AddSingleton<ICategoryMapper, CategoryMapper>();

        // services
        //builder.Services.AddScoped<ICategoryService, CategoryService>();

        // use cases
        // - campaign
        //builder.Services.AddSingleton<ISearchCampaign, SearchCampaign>();
    }

    private static void RegistryDomainServices(WebApplicationBuilder builder)
    {
    }

    private static void RegistryIncomingServices(WebApplicationBuilder builder)
    {
        //builder.Services.AddHostedService<CampaignStatusAdjustmentKafkaListener>();
        //builder.Services.AddHostedService<PacingBalanceInsufficientKafkaListener>();
    }

    private static void RegistryInfrastructureServices(WebApplicationBuilder builder)
    {
        // Configuration contexts
        //builder.Services.AddSingleton<IElasticContext, ElasticContext>();
        //builder.Services.AddSingleton<IElasticClient, ElasticClient>();
        //builder.Services.AddSingleton<IKafkaContext, KafkaContext>();


        // Repositories  
        //builder.Services.AddSingleton<IElasticCampaign, ElasticCampaign>();
    }
    private static void RegistryOutgoingServices(WebApplicationBuilder builder)
    {
        // Messaging  
        //builder.Services.AddSingleton<ICampaignStatusAdjustmentEventPublisher, CampaignStatusAdjustmentKafkaPublisher>();
    }
}