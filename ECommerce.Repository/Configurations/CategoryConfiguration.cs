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

            builder.Property(c => c.Name).HasMaxLength(100);

            builder.ToTable("Categories");
        }
    }
}
