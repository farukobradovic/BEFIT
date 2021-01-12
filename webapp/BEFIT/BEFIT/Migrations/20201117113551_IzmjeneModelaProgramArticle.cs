using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class IzmjeneModelaProgramArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUser",
                table: "ProgramArticle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "ProgramArticle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ProgramArticle",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProgramArticle_UserId",
                table: "ProgramArticle",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramArticle_AspNetUsers_UserId",
                table: "ProgramArticle",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramArticle_AspNetUsers_UserId",
                table: "ProgramArticle");

            migrationBuilder.DropIndex(
                name: "IX_ProgramArticle_UserId",
                table: "ProgramArticle");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "ProgramArticle");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProgramArticle");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProgramArticle");
        }
    }
}
