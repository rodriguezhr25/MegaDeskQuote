using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskQuote.Migrations
{
    public partial class Material : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RushDay",
                table: "DeskQuote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RushDay",
                table: "DeskQuote");
        }
    }
}
