using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitShop.Migrations
{
    public partial class doubletodics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "shoppingCartItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Fruties",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 1,
                column: "Price",
                value: 2.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                column: "Price",
                value: 2.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 3,
                column: "Price",
                value: 3.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 4,
                column: "Price",
                value: 4.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5,
                column: "Price",
                value: 5.9500000000000002);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "shoppingCartItems");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Fruties",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 1,
                column: "Price",
                value: 2.95m);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 2,
                column: "Price",
                value: 2.95m);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 3,
                column: "Price",
                value: 3.95m);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 4,
                column: "Price",
                value: 4.95m);

            migrationBuilder.UpdateData(
                table: "Fruties",
                keyColumn: "FruitId",
                keyValue: 5,
                column: "Price",
                value: 5.95m);
        }
    }
}
