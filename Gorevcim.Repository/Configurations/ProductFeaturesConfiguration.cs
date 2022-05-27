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
    public class ProductFeaturesConfiguration : IEntityTypeConfiguration<ProductFeatures>
    {
        public void Configure(EntityTypeBuilder<ProductFeatures> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);

            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductFeatures).HasForeignKey(x=>x.ProductId);      
        }
    }
}
