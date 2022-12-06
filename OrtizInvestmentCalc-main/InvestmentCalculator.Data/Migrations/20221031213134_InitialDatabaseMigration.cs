using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestmentCalculator.Data.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvestmentCalcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Compounds = table.Column<int>(type: "INTEGER", nullable: false),
                    Interest = table.Column<decimal>(type: "TEXT", nullable: false),
                    Principal = table.Column<int>(type: "INTEGER", nullable: false),
                    Years = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentCalcs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestmentCalcs");
        }
    }
}
