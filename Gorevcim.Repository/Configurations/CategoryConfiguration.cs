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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Ortak alanlar
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1,1); 
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
            

            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);


            builder.ToTable("Categories");
        }
    }
}
