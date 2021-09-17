using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressEats.Migrations
{
    public partial class registerupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Address1",
                table: "Order",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Order",
                newName: "Address1");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
