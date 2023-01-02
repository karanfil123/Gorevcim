using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TechnicalWebUrl",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogoFilePath",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogoFileName",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExplanationWebUrl",
                table: "Products",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Products",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 19, 3, 664, DateTimeKind.Local).AddTicks(7055), new DateTime(2022, 5, 26, 18, 19, 3, 664, DateTimeKind.Local).AddTicks(7065), new DateTime(2022, 5, 26, 18, 19, 3, 664, DateTimeKind.Local).AddTicks(7065) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TechnicalWebUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogoFilePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogoFileName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExplanationWebUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 17, 45, 4, 348, DateTimeKind.Local).AddTicks(791), new DateTime(2022, 5, 26, 17, 45, 4, 348, DateTimeKind.Local).AddTicks(800), new DateTime(2022, 5, 26, 17, 45, 4, 348, DateTimeKind.Local).AddTicks(799) });
        }
    }
}
