using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskQuote.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Drawers",
                table: "DeskQuote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Drawers",
                table: "DeskQuote");
        }
    }
}
