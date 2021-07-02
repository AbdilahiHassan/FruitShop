using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitShop.Migrations
{
    public partial class fixedURLS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                column: "ImagethumnailUrl",
                value: "/Images/thumbnails/Banana.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                column: "ImagethumnailUrl",
                value: "\\Images\\thumbnails\\ImagethumnailUrl.jpg");
        }
    }
}
