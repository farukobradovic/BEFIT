using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class authorIdInTrainingUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorID",
                table: "TrainingUser",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingUser_AuthorID",
                table: "TrainingUser",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingUser_AspNetUsers_AuthorID",
                table: "TrainingUser",
                column: "AuthorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingUser_AspNetUsers_AuthorID",
                table: "TrainingUser");

            migrationBuilder.DropIndex(
                name: "IX_TrainingUser_AuthorID",
                table: "TrainingUser");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "TrainingUser");
        }
    }
}
