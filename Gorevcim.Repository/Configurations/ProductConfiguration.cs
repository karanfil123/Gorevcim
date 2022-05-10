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
            //Ortak alanlar
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.CreateUserId).IsRequired();
            builder.Property(c => c.UpdateDate).IsRequired();
            builder.Property(c => c.UpdateUserId).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsActiveDate).IsRequired();
            builder.Property(c => c.IsActiveDateUserId).IsRequired();
            builder.Property(c => c.IsActiveDateUpdate).IsRequired();
            builder.Property(c => c.IsActiveDateUpdateUserId).IsRequired();
            builder.Property(c => c.IsDelete).IsRequired();
            builder.Property(c => c.IsDeleteDate).IsRequired();
            builder.Property(c => c.IsDeleteDateUserId).IsRequired();
            builder.Property(c => c.IsDeleteDateUpdate).IsRequired();
            builder.Property(c => c.IsDeleteUpdateUserId).IsRequired();

            builder.Property(p=>p.CategoryId).IsRequired();
            builder.Property(p=>p.ProductFeaturesId).IsRequired();
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(350);
            builder.Property(p=>p.Code).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.Barcode).IsRequired().HasMaxLength(350);
            builder.Property(p => p.ExpirationDate).IsRequired();
            builder.Property(p => p.Mixture).IsRequired();
            builder.Property(p => p.Explanation).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.LogoBase64Content).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.LogoFileName).IsRequired().HasMaxLength(250);
            builder.Property(p => p.LogoFilePath).IsRequired().HasMaxLength(250);
            builder.Property(p => p.TechnicalWebUrl).IsRequired().HasMaxLength(250);
            builder.Property(p => p.ExplanationWebUrl).IsRequired().HasMaxLength(250);

        }
    }
}
