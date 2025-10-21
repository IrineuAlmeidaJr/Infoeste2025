using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntitiesConfiguration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories");

        builder.HasKey(category => category.Id);
        builder.Property(category => category.Name).HasMaxLength(250).IsRequired();
        builder.Property(category => category.CreatedAt).IsRequired();
        builder.Property(category => category.UpdatedAt).IsRequired();

        builder.HasIndex(category => category.Name).IsUnique();

        builder.HasData(
            new List<Category>
            {
                new Category(1, "Informática", DateTime.UtcNow, DateTime.UtcNow),
                new Category(2, "Eletroportáteis", DateTime.UtcNow, DateTime.UtcNow),
                new Category(3, "Áudio e Vídeo", DateTime.UtcNow, DateTime.UtcNow),
                new Category(4, "Culinária e Cozinha", DateTime.UtcNow, DateTime.UtcNow),
                new Category(5, "Esporte e Fitness", DateTime.UtcNow, DateTime.UtcNow),
                new Category(6, "Eletrodomésticos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(7, "Climatização", DateTime.UtcNow, DateTime.UtcNow),
                new Category(8, "Som e Acessórios", DateTime.UtcNow, DateTime.UtcNow),
                new Category(9, "Pequenos Eletrodomésticos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(10, "Utensílios de Cozinha", DateTime.UtcNow, DateTime.UtcNow),
                new Category(11, "Telefonia", DateTime.UtcNow, DateTime.UtcNow),
                new Category(12, "Telefonia Móvel", DateTime.UtcNow, DateTime.UtcNow),
                new Category(13, "Smartphones", DateTime.UtcNow, DateTime.UtcNow),
                new Category(14, "Tablets", DateTime.UtcNow, DateTime.UtcNow),
                new Category(15, "Acessórios de Celular", DateTime.UtcNow, DateTime.UtcNow),
                new Category(16, "Monitores", DateTime.UtcNow, DateTime.UtcNow),
                new Category(17, "Notebooks", DateTime.UtcNow, DateTime.UtcNow),
                new Category(18, "Computadores Desktop", DateTime.UtcNow, DateTime.UtcNow),
                new Category(19, "Periféricos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(20, "Cadeiras e Mesas Gamer", DateTime.UtcNow, DateTime.UtcNow),
                new Category(21, "TVs e Home Theater", DateTime.UtcNow, DateTime.UtcNow),
                new Category(22, "Projetores", DateTime.UtcNow, DateTime.UtcNow),
                new Category(23, "Câmeras e Filmadoras", DateTime.UtcNow, DateTime.UtcNow),
                new Category(24, "Fotografia e Acessórios", DateTime.UtcNow, DateTime.UtcNow),
                new Category(25, "Consoles e Jogos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(26, "Brinquedos Eletrônicos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(27, "Fones de Ouvido", DateTime.UtcNow, DateTime.UtcNow),
                new Category(28, "Caixas de Som", DateTime.UtcNow, DateTime.UtcNow),
                new Category(29, "Relógios Inteligentes", DateTime.UtcNow, DateTime.UtcNow),
                new Category(30, "Carregadores e Cabos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(31, "Móveis para Escritório", DateTime.UtcNow, DateTime.UtcNow),
                new Category(32, "Móveis para Sala", DateTime.UtcNow, DateTime.UtcNow),
                new Category(33, "Móveis para Quarto", DateTime.UtcNow, DateTime.UtcNow),
                new Category(34, "Móveis para Cozinha", DateTime.UtcNow, DateTime.UtcNow),
                new Category(35, "Decoração", DateTime.UtcNow, DateTime.UtcNow),
                new Category(36, "Iluminação", DateTime.UtcNow, DateTime.UtcNow),
                new Category(37, "Cama, Mesa e Banho", DateTime.UtcNow, DateTime.UtcNow),
                new Category(38, "Roupas Masculinas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(39, "Roupas Femininas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(40, "Roupas Infantis", DateTime.UtcNow, DateTime.UtcNow),
                new Category(41, "Calçados", DateTime.UtcNow, DateTime.UtcNow),
                new Category(42, "Bolsas e Mochilas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(43, "Bijuterias e Acessórios", DateTime.UtcNow, DateTime.UtcNow),
                new Category(44, "Beleza e Cosméticos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(45, "Perfumaria", DateTime.UtcNow, DateTime.UtcNow),
                new Category(46, "Saúde e Bem-estar", DateTime.UtcNow, DateTime.UtcNow),
                new Category(47, "Suplementos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(48, "Alimentos e Bebidas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(49, "Hortifruti", DateTime.UtcNow, DateTime.UtcNow),
                new Category(50, "Padaria e Confeitaria", DateTime.UtcNow, DateTime.UtcNow),
                new Category(51, "Utensílios Domésticos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(52, "Ferramentas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(53, "Materiais de Construção", DateTime.UtcNow, DateTime.UtcNow),
                new Category(54, "Automotivo", DateTime.UtcNow, DateTime.UtcNow),
                new Category(55, "Moto e Bicicleta", DateTime.UtcNow, DateTime.UtcNow),
                new Category(56, "Brinquedos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(57, "Games e Consoles", DateTime.UtcNow, DateTime.UtcNow),
                new Category(58, "Papéis e Escritório", DateTime.UtcNow, DateTime.UtcNow),
                new Category(59, "Eletrônicos de Carro", DateTime.UtcNow, DateTime.UtcNow),
                new Category(60, "Roupas Íntimas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(61, "Produtos Pet", DateTime.UtcNow, DateTime.UtcNow),
                new Category(62, "Acessórios para Animais", DateTime.UtcNow, DateTime.UtcNow),
                new Category(63, "Jardinagem", DateTime.UtcNow, DateTime.UtcNow),
                new Category(64, "Ferramentas Elétricas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(65, "Segurança Residencial", DateTime.UtcNow, DateTime.UtcNow),
                new Category(66, "Câmeras de Segurança", DateTime.UtcNow, DateTime.UtcNow),
                new Category(67, "Iluminação Inteligente", DateTime.UtcNow, DateTime.UtcNow),
                new Category(68, "Ar Condicionado", DateTime.UtcNow, DateTime.UtcNow),
                new Category(69, "Ventiladores", DateTime.UtcNow, DateTime.UtcNow),
                new Category(70, "Aquecedores", DateTime.UtcNow, DateTime.UtcNow),
                new Category(71, "Micro-ondas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(72, "Geladeiras", DateTime.UtcNow, DateTime.UtcNow),
                new Category(73, "Freezers", DateTime.UtcNow, DateTime.UtcNow),
                new Category(74, "Fogões e Cooktops", DateTime.UtcNow, DateTime.UtcNow),
                new Category(75, "Lavadoras de Roupas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(76, "Secadoras de Roupas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(77, "Máquinas de Lavar Louça", DateTime.UtcNow, DateTime.UtcNow),
                new Category(78, "Fritadeiras e Air Fryers", DateTime.UtcNow, DateTime.UtcNow),
                new Category(79, "Liquidificadores e Batedeiras", DateTime.UtcNow, DateTime.UtcNow),
                new Category(80, "Cafeteiras e Chaleiras", DateTime.UtcNow, DateTime.UtcNow),
                new Category(81, "Panelas Elétricas", DateTime.UtcNow, DateTime.UtcNow),
                new Category(82, "Aparelhos de Pressão e Massageadores", DateTime.UtcNow, DateTime.UtcNow),
                new Category(83, "Rastreador de Atividades", DateTime.UtcNow, DateTime.UtcNow),
                new Category(84, "Fones Bluetooth", DateTime.UtcNow, DateTime.UtcNow),
                new Category(85, "Caixas de Som Portáteis", DateTime.UtcNow, DateTime.UtcNow),
                new Category(86, "Adaptadores e Cabos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(87, "Memórias e Pen Drives", DateTime.UtcNow, DateTime.UtcNow),
                new Category(88, "Placas de Vídeo", DateTime.UtcNow, DateTime.UtcNow),
                new Category(89, "Processadores", DateTime.UtcNow, DateTime.UtcNow),
                new Category(90, "Placas Mãe", DateTime.UtcNow, DateTime.UtcNow),
                new Category(91, "Roteadores e Modems", DateTime.UtcNow, DateTime.UtcNow),
                new Category(92, "Smart Home", DateTime.UtcNow, DateTime.UtcNow),
                new Category(93, "Dispositivos IoT", DateTime.UtcNow, DateTime.UtcNow),
                new Category(94, "Produtos Educacionais", DateTime.UtcNow, DateTime.UtcNow),
                new Category(95, "Instrumentos Musicais", DateTime.UtcNow, DateTime.UtcNow),
                new Category(96, "Material Escolar", DateTime.UtcNow, DateTime.UtcNow),
                new Category(97, "Agenda e Planner", DateTime.UtcNow, DateTime.UtcNow),
                new Category(98, "Cadernos e Blocos", DateTime.UtcNow, DateTime.UtcNow),
                new Category(99, "Artigos de Papelaria", DateTime.UtcNow, DateTime.UtcNow),
                new Category(100, "Kits e Combos", DateTime.UtcNow, DateTime.UtcNow)
            }
        );
    }
}
