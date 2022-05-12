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
    public class ProductVatUnitConfigureation : IEntityTypeConfiguration<ProductVatUnit>
    {
        public void Configure(EntityTypeBuilder<ProductVatUnit> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Code).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Explanation).IsRequired().HasMaxLength(1000);
            builder.HasOne(x => x.ProductFeatures).WithOne(x => x.ProductVatUnit).HasForeignKey<ProductVatUnit>(x => x.ProductFeaturesId);

        }
    }
}
