using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TechnicalWebUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550);

            migrationBuilder.AlterColumn<string>(
                name: "LogoFilePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550);

            migrationBuilder.AlterColumn<string>(
                name: "LogoFileName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550);

            migrationBuilder.AlterColumn<string>(
                name: "ExplanationWebUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550);

            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 17, 19, 19, 30, 752, DateTimeKind.Local).AddTicks(9032), new DateTime(2022, 5, 17, 19, 19, 30, 752, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 5, 17, 19, 19, 30, 752, DateTimeKind.Local).AddTicks(9040) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TechnicalWebUrl",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LogoFilePath",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LogoFileName",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ExplanationWebUrl",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Products",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 13, 19, 19, 22, 704, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 5, 13, 19, 19, 22, 704, DateTimeKind.Local).AddTicks(7653), new DateTime(2022, 5, 13, 19, 19, 22, 704, DateTimeKind.Local).AddTicks(7653) });
        }
    }
}
