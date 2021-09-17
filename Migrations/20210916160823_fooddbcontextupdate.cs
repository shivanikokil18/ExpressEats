using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressEats.Migrations
{
    public partial class fooddbcontextupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "LongDescription",
                value: "Pizza with topping of veggies");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "LongDescription",
                value: "Spicy red sauce pasta with veggies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "LongDescription",
                value: "Delicious pizza with topping of veggies");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "LongDescription",
                value: "Spicy red sauce pasta ");
        }
    }
}
