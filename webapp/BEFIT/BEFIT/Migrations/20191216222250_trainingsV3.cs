using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class trainingsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingUser");

            migrationBuilder.AddColumn<string>(
                name: "AuthorID",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Training",
                nullable: true);


            migrationBuilder.CreateIndex(
                name: "IX_Training_AuthorID",
                table: "Training",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserID",
                table: "Training",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_AspNetUsers_AuthorID",
                table: "Training",
                column: "AuthorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_AspNetUsers_UserID",
                table: "Training",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_AspNetUsers_AuthorID",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_AspNetUsers_UserID",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_AuthorID",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UserID",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Resolved",
                table: "Message");

            migrationBuilder.CreateTable(
                name: "TrainingUser",
                columns: table => new
                {
                    TrainingUserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorID = table.Column<string>(nullable: true),
                    TrainingID = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingUser", x => x.TrainingUserID);
                    table.ForeignKey(
                        name: "FK_TrainingUser_AspNetUsers_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingUser_Training_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Training",
                        principalColumn: "TrainingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingUser_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingUser_AuthorID",
                table: "TrainingUser",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingUser_TrainingID",
                table: "TrainingUser",
                column: "TrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingUser_UserID",
                table: "TrainingUser",
                column: "UserID");
        }
    }
}
