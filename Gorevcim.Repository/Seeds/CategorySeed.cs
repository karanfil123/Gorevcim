using Gorevcim.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Ofis Ürünleri" },
                new Category { Id = 2, Name = "Polen Haşere" },
                new Category { Id = 3, Name = "İzolasyon" },
                new Category { Id = 4, Name = "Tadilat" }
                );
        }
    }
}
