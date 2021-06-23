using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitShop.Migrations
{
    public partial class fixURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "/Images/thumbnails/Logo.png", "/Images/thumbnails/ImagethumnailUrl.jpg" });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "\\Images\\thumbnails\\Logo.png", "\\Images\\thumbnails\\ImagethumnailUrl.jpg" });

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
                columns: new[] { "ImageUrl", "IsOnSale" },
                values: new object[] { "\\Images\\thumbnails\\Logo.png", true });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ImagethumnailUrl", "IsOnSale" },
                values: new object[] { "\\Images\\thumbnails\\Logo.png", "\\Images\\thumbnails\\ImagethumnailUrl.jpg", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg" });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg" });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ImagethumnailUrl" },
                values: new object[] { "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg" });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "IsOnSale" },
                values: new object[] { "~\\Images\\Red_Apple.jpg  ", false });

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ImagethumnailUrl", "IsOnSale" },
                values: new object[] { "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", false });
        }
    }
}
