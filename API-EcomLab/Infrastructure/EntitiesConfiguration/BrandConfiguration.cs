using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("brands");

        builder.HasKey(brand => brand.Id);
        builder.Property(brand => brand.Name).HasMaxLength(150).IsRequired();
        builder.Property(brand => brand.CreatedAt).IsRequired();
        builder.Property(brand => brand.UpdatedAt).IsRequired();

        builder.HasData(
            new Brand(1, "Multilaser", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(2, "Philco", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(3, "Gradiente", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(4, "Mondial", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(5, "Fischer", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(6, "Cadence", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(7, "Britânia", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(8, "Lenoxx", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(9, "Arno", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(10, "Oster", DateTime.UtcNow, DateTime.UtcNow),
            new Brand(11, "Black+Decker", DateTime.UtcNow, DateTime.UtcNow),      
            new Brand(12, "Easynvest", DateTime.UtcNow, DateTime.UtcNow),          
            new Brand(13, "Fischer", DateTime.UtcNow, DateTime.UtcNow),            
            new Brand(14, "Mondial", DateTime.UtcNow, DateTime.UtcNow),            
            new Brand(15, "Cadence", DateTime.UtcNow, DateTime.UtcNow),            
            new Brand(16, "Britânia", DateTime.UtcNow, DateTime.UtcNow),           
            new Brand(17, "Arno", DateTime.UtcNow, DateTime.UtcNow),               
            new Brand(18, "Oster", DateTime.UtcNow, DateTime.UtcNow),              
            new Brand(19, "Lenoxx", DateTime.UtcNow, DateTime.UtcNow),             
            new Brand(20, "Philco", DateTime.UtcNow, DateTime.UtcNow),             
            new Brand(21, "Multilaser", DateTime.UtcNow, DateTime.UtcNow),         
            new Brand(22, "Gradiente", DateTime.UtcNow, DateTime.UtcNow),          
            new Brand(23, "Cuisinart", DateTime.UtcNow, DateTime.UtcNow),          
            new Brand(24, "Tramontina", DateTime.UtcNow, DateTime.UtcNow),         
            new Brand(25, "Samsung Brasil", DateTime.UtcNow, DateTime.UtcNow),     
            new Brand(26, "LG Brasil", DateTime.UtcNow, DateTime.UtcNow),          
            new Brand(27, "Intelbras", DateTime.UtcNow, DateTime.UtcNow),          
            new Brand(28, "Philips Brasil", DateTime.UtcNow, DateTime.UtcNow),     
            new Brand(29, "HP Brasil", DateTime.UtcNow, DateTime.UtcNow),          
            new Brand(30, "Lenovo Brasil", DateTime.UtcNow, DateTime.UtcNow)
        );
    }
}