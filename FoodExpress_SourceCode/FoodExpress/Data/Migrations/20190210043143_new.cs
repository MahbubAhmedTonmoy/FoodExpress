using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureHouse.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Spicyness",
                table: "products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Spicyness",
                table: "products");
        }
    }
}
