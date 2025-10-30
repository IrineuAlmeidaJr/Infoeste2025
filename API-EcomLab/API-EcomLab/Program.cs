using Application.Event;
using Application.Mapper;
using Application.Services;
using Application.UseCases.Brands;
using Application.UseCases.Categories;
using Application.UseCases.Products;
using Domain.Repository;
using Infrastructure.Configuration.Kafka;
using Infrastructure.Configurations;
using Infrastructure.Configurations.Redis;
using Infrastructure.Context;
using Infrastructure.Repository;
using Infrastructure.Repository.Redis;
using Microsoft.EntityFrameworkCore;
using Outgoing.Messaging;
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
        app.Services.GetRequiredService<IRedisContext>();
        app.Services.GetRequiredService<IKafkaContext>();
    }

    private static void RegistryApplicationServices(WebApplicationBuilder builder)
    {
        // mappers
        builder.Services.AddSingleton<ICategoryMapper, CategoryMapper>();
        builder.Services.AddSingleton<IBrandMapper, BrandMapper>();
        builder.Services.AddSingleton<IProductMapper, ProductMapper>();

        // services
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<IBrandService, BrandService>();
        builder.Services.AddScoped<IProductService, ProductService>();

        // UseCases
        // - Brand
        builder.Services.AddScoped<ICreateBrand, CreateBrand>();
        builder.Services.AddScoped<IUpdateBrand, UpdateBrand>();
        builder.Services.AddScoped<IRemoveBrand, RemoveBrand>();
        builder.Services.AddScoped<IGetBrandDtoById, GetBrandDtoById>();
        builder.Services.AddScoped<IGetBrandById, GetBrandById>();
        builder.Services.AddScoped<IGetBrandsPaged, GetBrandsPaged>();
        // - Category
        builder.Services.AddScoped<ICreateCategory, CreateCategory>();
        builder.Services.AddScoped<IUpdateCategory, UpdateCategory>();
        builder.Services.AddScoped<IRemoveCategory, RemoveCategory>();
        builder.Services.AddScoped<IGetCategoryDtoById, GetCategoryDtoById>();
        builder.Services.AddScoped<IGetCategoryById, GetCategoryById>();
        builder.Services.AddScoped<IGetCategoriesPaged, GetCategoriesPaged>();
        // - Product
        builder.Services.AddScoped<ICreateProduct, CreateProduct>();
        builder.Services.AddScoped<IUpdateProduct, UpdateProduct>();
        builder.Services.AddScoped<ISetProductStatus, SetProductStatus>();
        builder.Services.AddScoped<IGetProductResponseDtoById, GetProductResponseDtoById>();
        builder.Services.AddScoped<IGetProductsPaged, GetProductsPaged>();
    }

    private static void RegistryDomainServices(WebApplicationBuilder builder)
    {
    }

    private static void RegistryIncomingServices(WebApplicationBuilder builder)
    {

    }

    private static void RegistryInfrastructureServices(WebApplicationBuilder builder)
    {
        // Configuration contexts
        var connectionString = builder.Configuration.GetConnectionString("MySql");

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 42))));
        builder.Services.AddSingleton<IRedisContext, RedisContext>();
        builder.Services.AddSingleton<IKafkaContext, KafkaContext>();

        // Repositories  
        builder.Services.AddSingleton<ICacheRepository, CacheRepository>();
        builder.Services.AddSingleton<IRedisRepository, RedisRepository>();
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IBrandRepository, BrandRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
    }
    private static void RegistryOutgoingServices(WebApplicationBuilder builder)
    {
        // Messaging  
        builder.Services.AddSingleton<ICreateProductEventPublisher, CreateProductKafkaPublisher>();
        builder.Services.AddSingleton<IUpdateProductEventPublisher, UpdateProductKafkaPublisher>();
    }
}