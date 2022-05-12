using Gorevcim.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Gorevcim.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
              new Product
              {
                  Id = 1,
                  CategoryId = 1,
                  CreatedDate = DateTime.Now,
                  UpdateDate = DateTime.Now,
                  ExpirationDate=DateTime.Now,
                  SalePrice=110,
                  Stock=12,
                  PurchasePrice=23,
                  Barcode="AS123",
                  Code="123AS",
                  Name="Test ürün"                  
              },
              new Product
              {
                  Id = 2,
                  CategoryId = 2,
                  CreatedDate = DateTime.Now,
                  UpdateDate = DateTime.Now,
                  ExpirationDate = DateTime.Now,
                  SalePrice = 10,
                  Stock = 15,
                  PurchasePrice = 123,
                  Barcode = "XS123",
                  Code = "123XS",
                  Name = "Test Ürün2"
              },
              new Product
              {
                  Id = 3,
                  CategoryId = 3,
                  CreatedDate = DateTime.Now,
                  UpdateDate = DateTime.Now,
                  ExpirationDate = DateTime.Now,
                  SalePrice = 19,
                  Stock = 115,
                  PurchasePrice = 423,
                  Barcode = "XMAX423",
                  Code = "123XMAX",
                  Name = "Test Ürün3"
              });
        }
    }

}

