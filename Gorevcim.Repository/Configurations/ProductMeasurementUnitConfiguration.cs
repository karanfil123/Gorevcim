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
    public class ProductMeasurementUnitConfiguration : IEntityTypeConfiguration<ProductMeasurementUnit>
    {
        public void Configure(EntityTypeBuilder<ProductMeasurementUnit> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);


            builder.Property(c => c.Name).HasMaxLength(250);
            builder.Property(c => c.ShortCode).HasMaxLength(250);
            builder.Property(c => c.Explanation).HasMaxLength(1000);
            
            builder.HasOne(c=>c.ProductFeatures).WithOne(x=>x.ProductMeasurementUnit).HasForeignKey<ProductMeasurementUnit>(x => x.ProductFeaturesId);

            
        }
    }
}
