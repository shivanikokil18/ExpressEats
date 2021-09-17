using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressEats.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/Poha.jpg", "/images/Poha.jpg" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/Biryani.jpg", "/images/Biryani.jpg" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CategoryName", "DishName", "ImageThumbnailUrl", "ImageUrl", "IsDishOfTheWeek", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { 3, null, "Snacks", "Vadapav", "/images/vadapav.jpg", "/images/vadapav.jpg", false, "Mumbai special vadapav", 15m, "Teasty Snacks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/Alley.jpg", "/images/Alley.jpg" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/saadhu.jpg", "/images/saadhu.jpg" });
        }
    }
}
