using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCOllumnActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "products",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8239), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8248), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8251), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8260), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8262), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8264), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8267), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8270), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8271), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8273), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8278), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8279), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8284), new DateTime(2025, 10, 23, 20, 44, 42, 847, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1026), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1040), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1044), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1113), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1115), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1120), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1123), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1126), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1128), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1129), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1131), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1133), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1134), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1136), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1139), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1140), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1142), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1144), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1145), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1150), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1152), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1153), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1155), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1157), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1158), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1160), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1161), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1163), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1166), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1168), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1169), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1171), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1172), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1174), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1175), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1177), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1178), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1180), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1182), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1183), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1185), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1186), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1188), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1190), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1191), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1193), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1194), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1199), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1201), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1202), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1204), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1206), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1207), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1209), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1210), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1212), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1214), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1219), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1220), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1222), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1223), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1225), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1226), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1228), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1230), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1231), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1233), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1275), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1277), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1278), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1280), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1282), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1283), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1285), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1286), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1289), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1291), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1292), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1294), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1296), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1297), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1298), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1300), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1301), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1303), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1305), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1306), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1308), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1310), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1311), new DateTime(2025, 10, 23, 20, 44, 42, 848, DateTimeKind.Utc).AddTicks(1311) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "products");

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1260), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1271), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1275), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1276), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1277), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1279), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1280), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1281), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1282), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1284), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1334), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1335), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1336), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1337), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1338), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1340), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1341), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1342), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1343), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1344), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1345), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1347), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1348), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1350), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1351), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1352), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1353), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1354), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3373), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3381), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3385), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3386), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3389), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3391), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3392), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3393), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3395), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3398), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3399), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3400), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3402), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3403), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3404), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3406), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3407), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3408), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3409), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3412), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3445), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3446), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3447), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3449), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3450), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3451), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3452), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3453), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3455), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3456), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3458), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3459), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3460), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3461), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3462), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3463), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3464), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3466), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3467), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3468), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3469), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3470), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3471), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3472), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3474), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3476), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3477), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3478), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3481), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3482), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3483), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3484), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3486), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3488), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3489), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3491), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3493), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3498), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3499), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3500), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3501), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3502), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3503), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3505), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3506), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3508), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3512), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3514), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3515), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3516), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3517), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3518), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3520), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3522), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3523), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3524), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3525), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3527), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3529), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3530), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3531), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3549), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 10, 18, 19, 34, 17, 533, DateTimeKind.Utc).AddTicks(3551) });
        }
    }
}
