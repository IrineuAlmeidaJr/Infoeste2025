using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ean = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sku = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "product_category",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_category", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_product_category_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_category_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1260), "Multilaser", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1262) },
                    { 2L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1271), "Philco", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1271) },
                    { 3L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1273), "Gradiente", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1273) },
                    { 4L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1275), "Mondial", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1275) },
                    { 5L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1276), "Fischer", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1277) },
                    { 6L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1277), "Cadence", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1278) },
                    { 7L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1279), "Britânia", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1279) },
                    { 8L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1280), "Lenoxx", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1280) },
                    { 9L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1281), "Arno", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1281) },
                    { 10L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1282), "Oster", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1283) },
                    { 11L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1284), "Black+Decker", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1284) },
                    { 12L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1334), "Easynvest", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1334) },
                    { 13L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1335), "Fischer", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1335) },
                    { 14L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1336), "Mondial", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1336) },
                    { 15L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1337), "Cadence", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1338) },
                    { 16L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1338), "Britânia", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1339) },
                    { 17L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1340), "Arno", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1340) },
                    { 18L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1341), "Oster", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1341) },
                    { 19L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1342), "Lenoxx", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1342) },
                    { 20L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1343), "Philco", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1343) },
                    { 21L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1344), "Multilaser", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1345) },
                    { 22L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1345), "Gradiente", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1346) },
                    { 23L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1347), "Cuisinart", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1347) },
                    { 24L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1348), "Tramontina", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1348) },
                    { 25L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1349), "Samsung Brasil", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1349) },
                    { 26L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1350), "LG Brasil", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1350) },
                    { 27L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1351), "Intelbras", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1351) },
                    { 28L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1352), "Philips Brasil", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1352) },
                    { 29L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1353), "HP Brasil", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1353) },
                    { 30L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1354), "Lenovo Brasil", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1354) }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3373), "Informática", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3374) },
                    { 2L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3381), "Eletroportáteis", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3381) },
                    { 3L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3383), "Áudio e Vídeo", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3383) },
                    { 4L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3385), "Culinária e Cozinha", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3385) },
                    { 5L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3386), "Esporte e Fitness", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3387) },
                    { 6L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3389), "Eletrodomésticos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3389) },
                    { 7L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3391), "Climatização", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3391) },
                    { 8L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3392), "Som e Acessórios", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3392) },
                    { 9L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3393), "Pequenos Eletrodomésticos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3394) },
                    { 10L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3395), "Utensílios de Cozinha", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3395) },
                    { 11L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3396), "Telefonia", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3396) },
                    { 12L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3398), "Telefonia Móvel", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3398) },
                    { 13L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3399), "Smartphones", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3399) },
                    { 14L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3400), "Tablets", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3400) },
                    { 15L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3402), "Acessórios de Celular", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3402) },
                    { 16L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3403), "Monitores", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3403) },
                    { 17L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3404), "Notebooks", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3404) },
                    { 18L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3406), "Computadores Desktop", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3406) },
                    { 19L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3407), "Periféricos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3407) },
                    { 20L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3408), "Cadeiras e Mesas Gamer", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3408) },
                    { 21L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3409), "TVs e Home Theater", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3409) },
                    { 22L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3410), "Projetores", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3411) },
                    { 23L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3412), "Câmeras e Filmadoras", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3412) },
                    { 24L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3444), "Fotografia e Acessórios", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3444) },
                    { 25L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3445), "Consoles e Jogos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3445) },
                    { 26L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3446), "Brinquedos Eletrônicos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3446) },
                    { 27L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3447), "Fones de Ouvido", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3448) },
                    { 28L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3449), "Caixas de Som", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3449) },
                    { 29L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3450), "Relógios Inteligentes", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3450) },
                    { 30L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3451), "Carregadores e Cabos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3451) },
                    { 31L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3452), "Móveis para Escritório", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3452) },
                    { 32L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3453), "Móveis para Sala", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3454) },
                    { 33L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3455), "Móveis para Quarto", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3455) },
                    { 34L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3456), "Móveis para Cozinha", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3457) },
                    { 35L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3458), "Decoração", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3458) },
                    { 36L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3459), "Iluminação", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3459) },
                    { 37L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3460), "Cama, Mesa e Banho", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3460) },
                    { 38L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3461), "Roupas Masculinas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3461) },
                    { 39L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3462), "Roupas Femininas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3462) },
                    { 40L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3463), "Roupas Infantis", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3464) },
                    { 41L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3464), "Calçados", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3465) },
                    { 42L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3466), "Bolsas e Mochilas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3466) },
                    { 43L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3467), "Bijuterias e Acessórios", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3467) },
                    { 44L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3468), "Beleza e Cosméticos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3468) },
                    { 45L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3469), "Perfumaria", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3469) },
                    { 46L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3470), "Saúde e Bem-estar", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3470) },
                    { 47L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3471), "Suplementos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3472) },
                    { 48L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3472), "Alimentos e Bebidas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3473) },
                    { 49L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3474), "Hortifruti", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3474) },
                    { 50L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3475), "Padaria e Confeitaria", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3475) },
                    { 51L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3476), "Utensílios Domésticos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3476) },
                    { 52L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3477), "Ferramentas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3478) },
                    { 53L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3478), "Materiais de Construção", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3479) },
                    { 54L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3480), "Automotivo", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3480) },
                    { 55L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3481), "Moto e Bicicleta", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3481) },
                    { 56L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3482), "Brinquedos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3482) },
                    { 57L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3483), "Games e Consoles", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3484) },
                    { 58L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3484), "Papéis e Escritório", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3485) },
                    { 59L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3486), "Eletrônicos de Carro", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3486) },
                    { 60L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3487), "Roupas Íntimas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3487) },
                    { 61L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3488), "Produtos Pet", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3488) },
                    { 62L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3489), "Acessórios para Animais", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3489) },
                    { 63L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3490), "Jardinagem", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3491) },
                    { 64L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3491), "Ferramentas Elétricas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3492) },
                    { 65L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3493), "Segurança Residencial", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3493) },
                    { 66L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3494), "Câmeras de Segurança", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3495) },
                    { 67L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3496), "Iluminação Inteligente", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3496) },
                    { 68L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3497), "Ar Condicionado", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3497) },
                    { 69L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3498), "Ventiladores", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3498) },
                    { 70L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3499), "Aquecedores", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3499) },
                    { 71L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3500), "Micro-ondas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3500) },
                    { 72L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3501), "Geladeiras", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3501) },
                    { 73L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3502), "Freezers", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3503) },
                    { 74L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3503), "Fogões e Cooktops", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3504) },
                    { 75L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3505), "Lavadoras de Roupas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3505) },
                    { 76L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3506), "Secadoras de Roupas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3506) },
                    { 77L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3507), "Máquinas de Lavar Louça", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3507) },
                    { 78L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3508), "Fritadeiras e Air Fryers", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3508) },
                    { 79L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3509), "Liquidificadores e Batedeiras", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3510) },
                    { 80L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3510), "Cafeteiras e Chaleiras", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3511) },
                    { 81L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3512), "Panelas Elétricas", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3512) },
                    { 82L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3513), "Aparelhos de Pressão e Massageadores", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3513) },
                    { 83L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3514), "Rastreador de Atividades", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3514) },
                    { 84L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3515), "Fones Bluetooth", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3515) },
                    { 85L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3516), "Caixas de Som Portáteis", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3516) },
                    { 86L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3517), "Adaptadores e Cabos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3518) },
                    { 87L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3518), "Memórias e Pen Drives", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3519) },
                    { 88L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3520), "Placas de Vídeo", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3520) },
                    { 89L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3521), "Processadores", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3521) },
                    { 90L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3522), "Placas Mãe", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3522) },
                    { 91L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3523), "Roteadores e Modems", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3523) },
                    { 92L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3524), "Smart Home", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3524) },
                    { 93L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3525), "Dispositivos IoT", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3525) },
                    { 94L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3526), "Produtos Educacionais", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3527) },
                    { 95L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3527), "Instrumentos Musicais", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3528) },
                    { 96L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3529), "Material Escolar", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3529) },
                    { 97L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3530), "Agenda e Planner", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3530) },
                    { 98L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3531), "Cadernos e Blocos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3531) },
                    { 99L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3549), "Artigos de Papelaria", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3549) },
                    { 100L, new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3550), "Kits e Combos", new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3551) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_Name",
                table: "categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_category_CategoryId",
                table: "product_category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrandId",
                table: "products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_category");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brands");
        }
    }
}
