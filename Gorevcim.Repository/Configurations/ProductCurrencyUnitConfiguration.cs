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
    public class ProductCurrencyUnitConfiguration : IEntityTypeConfiguration<ProductCurrencyUnit>
    {
        public void Configure(EntityTypeBuilder<ProductCurrencyUnit> builder)
        {
           
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);           

            builder.Property(pc=>pc.Name).IsRequired().HasMaxLength(250);
            builder.Property(pc=>pc.ShortCode).IsRequired().HasMaxLength(250);
            builder.Property(pc=>pc.Explanation).IsRequired().HasMaxLength(1000);

            builder.HasOne(x => x.ProductFeatures).WithOne(x => x.ProductCurrencyUnit).HasForeignKey<ProductCurrencyUnit>(x => x.ProductFeaturesId);
        }
    }
}
