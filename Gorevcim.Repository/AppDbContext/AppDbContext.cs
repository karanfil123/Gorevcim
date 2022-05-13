using Gorevcim.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.AppDbContext
{
    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }
        public DbSet<ProductsBrand> ProductsBrands { get; set; }
        public DbSet<ProductsColor> ProductsColors { get; set; }
        public DbSet<ProductCurrencyUnit> ProductCurrencyUnits { get; set; }
        public DbSet<ProductMeasurementUnit> ProductMeasurementUnits { get; set; }
        public DbSet<ProductsWeightUnit> ProductsWeightUnits { get; set; }
        public DbSet<ProductVatUnit> ProductVatUnits { get; set; }
        public DbSet<ProductProject> ProductProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);            
        }
    }
}
