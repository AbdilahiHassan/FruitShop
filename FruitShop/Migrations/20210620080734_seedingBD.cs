using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitShop.Migrations
{
    public partial class seedingBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Fruit Banana" },
                    { 2, null, "Fruit Apple" },
                    { 3, null, "Fruit Pineapple" },
                    { 4, null, "Fruit Grape" },
                    { 5, null, "Fruit Watermelon" }
                });

            migrationBuilder.InsertData(
                table: "Fruties",
                columns: new[] { "FruitId", "CategoryId", "Description", "ImageUrl", "ImagethumnailUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health", "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", true, false, "mixed fruit", 2.95m },
                    { 2, 1, "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health", "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", true, false, "mixed fruit", 2.95m },
                    { 3, 1, "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health", "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", true, false, "mixed fruit", 3.95m },
                    { 4, 1, "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health", "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", true, false, "mixed fruit", 4.95m },
                    { 5, 1, "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health", "~\\Images\\Red_Apple.jpg  ", "~\\Images\\thumbnails\\ImagethumnailUrl.jpg", true, false, "mixed fruit", 5.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
