using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 27, 16, 58, 11, 417, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 5, 27, 16, 58, 11, 417, DateTimeKind.Local).AddTicks(149), new DateTime(2022, 5, 27, 16, 58, 11, 417, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 19, 3, 664, DateTimeKind.Local).AddTicks(7055), new DateTime(2022, 5, 26, 18, 19, 3, 664, DateTimeKind.Local).AddTicks(7065), new DateTime(2022, 5, 26, 18, 19, 3, 664, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);
        }
    }
}
