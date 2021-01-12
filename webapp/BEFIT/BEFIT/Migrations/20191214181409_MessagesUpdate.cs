using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class MessagesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Message",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserID",
                table: "Message",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_UserID",
                table: "Message",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_UserID",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_UserID",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Message");
        }
    }
}
