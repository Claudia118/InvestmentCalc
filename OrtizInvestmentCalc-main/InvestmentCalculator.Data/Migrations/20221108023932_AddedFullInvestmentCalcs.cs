using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestmentCalculator.Data.Migrations
{
    public partial class AddedFullInvestmentCalcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Years",
                table: "InvestmentCalcs",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "Principal",
                table: "InvestmentCalcs",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<decimal>(
                name: "Full",
                table: "InvestmentCalcs",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Full",
                table: "InvestmentCalcs");

            migrationBuilder.AlterColumn<int>(
                name: "Years",
                table: "InvestmentCalcs",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Principal",
                table: "InvestmentCalcs",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }
    }
}
