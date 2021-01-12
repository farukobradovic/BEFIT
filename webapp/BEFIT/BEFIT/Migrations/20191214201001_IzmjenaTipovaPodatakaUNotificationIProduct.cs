using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BEFIT.Migrations
{
    public partial class IzmjenaTipovaPodatakaUNotificationIProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ProductDate",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfPublishing",
                table: "Notification",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DateOfPublishing",
                table: "Notification");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDate",
                table: "Product",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
