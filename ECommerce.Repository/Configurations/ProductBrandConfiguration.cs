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
    public class ProductBrandConfiguration : IEntityTypeConfiguration<ProductsBrand>
    {
        public void Configure(EntityTypeBuilder<ProductsBrand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn(1,1);
            builder.Property(x=>x.BrandsName).HasMaxLength(250);
            builder.Property(x=>x.BrandsWeUrl).HasMaxLength(250);
            builder.Property(x=>x.Explanation).HasMaxLength(250);
            builder.Property(x=>x.LogoFileName).HasMaxLength(250);
            builder.Property(x=>x.LogoFilePath).HasMaxLength(250);
            
            builder.HasOne(x=>x.ProductFeatures).WithOne(x=>x.ProductsBrand).HasForeignKey<ProductsBrand>(x=>x.ProductFeaturesId);

        }
    }
}
