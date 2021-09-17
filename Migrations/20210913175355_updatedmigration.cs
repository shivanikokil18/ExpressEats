using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressEats.Migrations
{
    public partial class updatedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "IsDishOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "IsDishOfTheWeek",
                value: true);

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CategoryName", "DishName", "ImageThumbnailUrl", "ImageUrl", "IsDishOfTheWeek", "LongDescription", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 4, null, "Dinner", "Pizza", "/images/Pizza.jpg", "/images/Pizza.jpg", false, "Delicious pizza with topping of veggies", 150m, "Veg Paradise Pizza" },
                    { 5, null, "Dinner", "Noodles", "/images/Noodles.jpg", "/images/Noodles.jpg", true, "Spicy noodles with fresh veggies", 165m, "Spicy Veg Noodles" },
                    { 6, null, "Lunch", "Kulcha", "/images/Kulcha.jpg", "/images/Kulcha.jpg", false, "Hot kulcha for lunch", 45m, "Hot Kulcha" },
                    { 7, null, "Snacks", "Pasta", "/images/Pasta.jpg", "/images/Pasta.jpg", false, "Spicy red sauce pasta ", 50m, "Teasty pasta" },
                    { 8, null, "Snacks", "Spaghetti", "/images/Spaghetti.jpg", "/images/Spaghetti.jpg", false, "spaghetti With veggies", 80m, "Teasty Snacks" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "IsDishOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "IsDishOfTheWeek",
                value: false);
        }
    }
}
