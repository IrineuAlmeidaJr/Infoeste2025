using Application.Mapper;
using Application.Services;
using Domain.Repository;
using Incoming.Messaging;
using Infrastructure.Configuration.Elastic;
using Infrastructure.Configuration.Kafka;
using Infrastructure.Configurations;
using Infrastructure.Configurations.Redis;
using Infrastructure.Repository;
using Infrastructure.Repository.Elastic;
using Infrastructure.Repository.Redis;
using Nest;
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

        builder.Services.AddControllers();
        builder.Services.AddHttpClient();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Host.UseSerilog();

        if (builder.Environment.IsDevelopment())
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost", policy =>
                {
                    policy.WithOrigins("http://localhost:3000")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
        }

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseCors("AllowLocalhost");
        }

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
        app.Services.GetRequiredService<IElasticContext>();
        app.Services.GetRequiredService<IRedisContext>();
        app.Services.GetRequiredService<IKafkaContext>();
    }

    private static void RegistryApplicationServices(WebApplicationBuilder builder)
    {
        // mappers
        builder.Services.AddSingleton<IProductMapper, ProductMapper>();

        // services
        builder.Services.AddSingleton<IProductService, ProductService>();
    }

    private static void RegistryDomainServices(WebApplicationBuilder builder)
    {
    }

    private static void RegistryIncomingServices(WebApplicationBuilder builder)
    {
        builder.Services.AddHostedService<CreateProductKafkaListener>();
        builder.Services.AddHostedService<UpdateProductKafkaListener>();
    }

    private static void RegistryInfrastructureServices(WebApplicationBuilder builder)
    {
        // Configuration contexts
        builder.Services.AddSingleton<IElasticContext, ElasticContext>();
        builder.Services.AddSingleton<IElasticClient, ElasticClient>();
        builder.Services.AddSingleton<IKafkaContext, KafkaContext>();
        builder.Services.AddSingleton<IRedisContext, RedisContext>();


        // Repositories  
        builder.Services.AddSingleton<IRedisRepository, RedisRepository>();
        builder.Services.AddSingleton<ICacheRepository, CacheRepository>();
        builder.Services.AddSingleton<IElasticProduct, ElasticProduct>();
        builder.Services.AddSingleton<IProductRepository, ProductRepository>();
    }
}