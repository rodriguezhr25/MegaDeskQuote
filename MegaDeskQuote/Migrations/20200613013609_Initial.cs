using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskQuote.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(maxLength: 60, nullable: false),
                    DateQuote = table.Column<DateTime>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    CostSize = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalSize = table.Column<int>(nullable: false),
                    SizeOverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Drawers = table.Column<int>(nullable: false),
                    DrawerCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    MaterialCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ShippingMethod = table.Column<string>(nullable: true),
                    ShippingCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Material = table.Column<int>(nullable: false),
                    RushDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
