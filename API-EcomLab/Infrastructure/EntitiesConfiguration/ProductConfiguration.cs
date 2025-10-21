using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");

        builder.HasKey(product => product.Id);
        builder.Property(product => product.Name).IsRequired().HasMaxLength(150);
        builder.Property(product => product.Description).HasMaxLength(4000);
        builder.Property(product => product.BrandId).IsRequired();
        builder.Property(product => product.Ean).IsRequired().HasMaxLength(13);
        builder.Property(product => product.Sku).IsRequired().HasMaxLength(20);
        builder.Property(product => product.Stock).IsRequired();
        builder.Property(product => product.BasePrice).IsRequired().HasPrecision(10, 2);
        builder.Property(product => product.ImageUrl).HasMaxLength(2500);
        builder.Property(product => product.CreatedAt).IsRequired();
        builder.Property(product => product.UpdatedAt).IsRequired();

        //Relacionamento => N:1 Product - Brand
        builder.HasOne(product => product.Brand)
               .WithMany(brand => brand.Products)
               .HasForeignKey(product => product.BrandId);

        // Relacionamento => N:N Product - Category
        builder.HasMany(product => product.Categories)
               .WithMany(category => category.Products)
               .UsingEntity<Dictionary<string, object>>(
                    "product_category",
                    prod_cat => prod_cat.HasOne<Category>().WithMany().HasForeignKey("CategoryId"),
                    prod_cat => prod_cat.HasOne<Product>().WithMany().HasForeignKey("ProductId"),
                    prod_cat =>
                    {
                        prod_cat.HasKey("ProductId", "CategoryId");
                        prod_cat.ToTable("product_category");
                    }
               );
    }
}