using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressEats.Migrations
{
    public partial class update2dmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "LongDescription",
                value: "Rich Spicy flavoured veg biryani");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "LongDescription",
                value: "Rich Spices flavoured veg biryani");
        }
    }
}
