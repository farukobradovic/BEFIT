using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class statistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Statistic",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<double>(
                name: "AverageBMI",
                table: "Statistic",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CalculatedBMI",
                table: "Statistic",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageBMI",
                table: "Statistic");

            migrationBuilder.DropColumn(
                name: "CalculatedBMI",
                table: "Statistic");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "Statistic",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
