using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskQuote.Migrations
{
    public partial class RushDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RushDays",
                table: "DeskQuote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RushDays",
                table: "DeskQuote");
        }
    }
}
