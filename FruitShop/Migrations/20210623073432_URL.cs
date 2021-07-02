using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitShop.Migrations
{
    public partial class URL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "IsOnSale" },
                values: new object[] { "/Images/thumbnails/Logo.png", true });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "/Images/thumbnails/Logo.png", "/Images/thumbnails/Red_Apple.jpg" });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl", "ImagethumnailUrl", "IsInStock" },
                values: new object[] { 2, "/Images/thumbnails/Logo.png", "/Images/thumbnails/ImagethumnailUrl.jpg", false });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { 2, "/Images/thumbnails/Logo.png", "/Images/thumbnails/ImagethumnailUrl.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "IsOnSale" },
                values: new object[] { "\\Images\\thumbnails\\Logo.png", false });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "\\Images\\thumbnails\\Logo.png", "\\Images\\thumbnails\\ImagethumnailUrl.jpg" });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl", "ImagethumnailUrl", "IsInStock" },
                values: new object[] { 1, "\\Images\\thumbnails\\Logo.png", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", true });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { 1, "\\Images\\thumbnails\\Logo.png", "\\Images\\thumbnails\\ImagethumnailUrl.jpg" });
        }
    }
}
