using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class stat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Statistic");

            migrationBuilder.RenameColumn(
                name: "ChangeDate",
                table: "Statistic",
                newName: "DateCalculated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCalculated",
                table: "Statistic",
                newName: "ChangeDate");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Statistic",
                nullable: true);
        }
    }
}
