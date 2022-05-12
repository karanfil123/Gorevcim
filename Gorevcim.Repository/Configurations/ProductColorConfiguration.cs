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
    public class ProductColorConfiguration : IEntityTypeConfiguration<ProductsColor>
    {
        public void Configure(EntityTypeBuilder<ProductsColor> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);

            builder.Property(x=>x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x=>x.Code).HasMaxLength(250).IsRequired();
            builder.Property(x=>x.Explanation).HasMaxLength(1000).IsRequired();
            builder.Property(x=>x.ColorFilepath).HasMaxLength(250).IsRequired();

            builder.HasOne(x=>x.ProductFeatures).WithOne(x=>x.ProductsColor).HasForeignKey<ProductsColor>(x=>x.ProductFeaturesId);
        }
    }
}
