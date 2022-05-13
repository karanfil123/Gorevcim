using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMixture = table.Column<bool>(type: "bit", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoFileName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    LogoFilePath = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    TechnicalWebUrl = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    ExplanationWebUrl = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCurrencyUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCurrencyUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMeasurementUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMeasurementUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductProjects_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandsName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BrandsWeUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoFileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LogoFilePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsBrands_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ColorBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorFilepath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsColors_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsWeightUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsWeightUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsWeightUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVatUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsExemption = table.Column<bool>(type: "bit", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVatUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVatUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateUserId", "CreatedDate", "IsActive", "IsActiveDate", "IsActiveDateUpdate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUserId", "IsDeleteUpdateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Ofis Ürünleri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Polen Haşere", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "İzolasyon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tadilat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "CategoryId", "Code", "CreateUserId", "CreatedDate", "ExpirationDate", "Explanation", "ExplanationWebUrl", "IsActive", "IsActiveDate", "IsActiveDateUpdate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUserId", "IsDeleteUpdateUserId", "IsMixture", "LogoBase64Content", "LogoFileName", "LogoFilePath", "Name", "PurchasePrice", "SalePrice", "Stock", "TechnicalWebUrl", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, "AS123", 1, "123AS", 0, new DateTime(2022, 5, 13, 18, 15, 26, 503, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 5, 13, 18, 15, 26, 503, DateTimeKind.Local).AddTicks(3387), "sdfklsdjlfkds", "sdjfhsdf", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "sdklf", "dkjfg", "dfjhdf", "Test ürün", 23m, 110m, 12, "klsdjfsd", new DateTime(2022, 5, 13, 18, 15, 26, 503, DateTimeKind.Local).AddTicks(3387), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCurrencyUnits_ProductFeaturesId",
                table: "ProductCurrencyUnits",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMeasurementUnits_ProductFeaturesId",
                table: "ProductMeasurementUnits",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductProjects_ProductFeaturesId",
                table: "ProductProjects",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBrands_ProductFeaturesId",
                table: "ProductsBrands",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsColors_ProductFeaturesId",
                table: "ProductsColors",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsWeightUnits_ProductFeaturesId",
                table: "ProductsWeightUnits",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductVatUnits_ProductFeaturesId",
                table: "ProductVatUnits",
                column: "ProductFeaturesId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCurrencyUnits");

            migrationBuilder.DropTable(
                name: "ProductMeasurementUnits");

            migrationBuilder.DropTable(
                name: "ProductProjects");

            migrationBuilder.DropTable(
                name: "ProductsBrands");

            migrationBuilder.DropTable(
                name: "ProductsColors");

            migrationBuilder.DropTable(
                name: "ProductsWeightUnits");

            migrationBuilder.DropTable(
                name: "ProductVatUnits");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
