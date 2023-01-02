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
                  ExpirationDate = DateTime.Now,
                  Explanation = "sdfklsdjlfkds",
                  LogoBase64Content = "sdklf",
                  TechnicalWebUrl = "klsdjfsd",
                  ExplanationWebUrl = "sdjfhsdf",
                  SalePrice = 110,
                  LogoFileName = "dkjfg",
                  LogoFilePath = "dfjhdf",
                  Stock = 12,
                  PurchasePrice = 23,
                  Barcode = "AS123",
                  Code = "123AS",
                  Name = "Test ürün"
              }) ;
        }
    }

}

