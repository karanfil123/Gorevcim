using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "PurchaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 13, 19, 8, 43, 872, DateTimeKind.Local).AddTicks(6298), new DateTime(2022, 5, 13, 19, 8, 43, 872, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 5, 13, 19, 8, 43, 872, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 5, 13, 19, 8, 43, 872, DateTimeKind.Local).AddTicks(6305) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 13, 18, 15, 26, 503, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 5, 13, 18, 15, 26, 503, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 5, 13, 18, 15, 26, 503, DateTimeKind.Local).AddTicks(3387) });
        }
    }
}
