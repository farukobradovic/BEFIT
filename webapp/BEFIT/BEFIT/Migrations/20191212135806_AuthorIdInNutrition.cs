using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class AuthorIdInNutrition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Nutrition",
                newName: "AuthorID");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorID",
                table: "Nutrition",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_AuthorID",
                table: "Nutrition",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrition_AspNetUsers_AuthorID",
                table: "Nutrition",
                column: "AuthorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutrition_AspNetUsers_AuthorID",
                table: "Nutrition");

            migrationBuilder.DropIndex(
                name: "IX_Nutrition_AuthorID",
                table: "Nutrition");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Nutrition",
                newName: "Author");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Nutrition",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
