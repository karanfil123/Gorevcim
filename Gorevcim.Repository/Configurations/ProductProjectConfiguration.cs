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
    public class ProductProjectConfiguration : IEntityTypeConfiguration<ProductProject>
    {
        public void Configure(EntityTypeBuilder<ProductProject> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);

            builder.Property(x=>x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x=>x.ShortCode).IsRequired().HasMaxLength(250);
            builder.Property(x=>x.Explanation).IsRequired().HasMaxLength(1000);

            builder.HasOne(x=>x.ProductFeatures).WithOne(x=>x.ProductProject).HasForeignKey<ProductProject>(x=>x.ProductFeaturesId);
        }
    }
}
