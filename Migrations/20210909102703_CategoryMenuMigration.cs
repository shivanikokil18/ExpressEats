using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressEats.Migrations
{
    public partial class CategoryMenuMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDishOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Snacks", "The most versatile and fresh medium" },
                    { 2, "Lunch", "The most versatile and fresh medium" },
                    { 3, "Dinner", "The most versatile and fresh medium" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CategoryName", "DishName", "ImageThumbnailUrl", "ImageUrl", "IsDishOfTheWeek", "LongDescription", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "Snacks", "Pohe", "/images/Pohe.jpg", "/images/Pohe.jpg", false, "Best Snacks for hunger", 15m, "Teasty Snacks" },
                    { 2, 2, "Lunch", "Biryani", "/Images/Biryani.jpg", "/images/Biryani.jpg", false, "Rich Spices flavoured veg biryani", 180m, "Veg Biryani" },
                    { 3, 1, "Snacks", "Vadapav", "/Images/vadapav.jpg", "/images/vadapav.jpg", false, "Mumbai special vadapav for hunger", 15m, "Spicy vadapav" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
