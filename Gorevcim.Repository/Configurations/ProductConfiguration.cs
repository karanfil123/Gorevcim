using Gorevcim.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);            
            builder.Property(p => p.Name).HasMaxLength(350);
            //builder.Property(p => p.Code).IsRequired().HasMaxLength(150);
            //builder.Property(p => p.Barcode).IsRequired().HasMaxLength(350);
            //builder.Property(p => p.Explanation).IsRequired().HasMaxLength(1000);
            //builder.Property(p => p.LogoFileName).IsRequired().HasMaxLength(550);
            //builder.Property(p => p.LogoFilePath).IsRequired().HasMaxLength(550);
            //builder.Property(p => p.TechnicalWebUrl).IsRequired().HasMaxLength(550);
            //builder.Property(p => p.ExplanationWebUrl).IsRequired().HasMaxLength(550);
            //builder.Property(p => p.PurchasePrice).HasColumnType("decimal(18,2)");
            //builder.Property(p => p.SalePrice).HasColumnType("decimal(18,2)");
           

            builder.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(x => x.CategoryId);//bire çok ilişki



        }
    }
}
