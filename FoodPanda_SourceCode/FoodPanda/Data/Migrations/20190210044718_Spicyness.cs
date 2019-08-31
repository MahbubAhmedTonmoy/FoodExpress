using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureHouse.Data.Migrations
{
    public partial class Spicyness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShadeColor",
                table: "products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShadeColor",
                table: "products",
                nullable: true);
        }
    }
}
