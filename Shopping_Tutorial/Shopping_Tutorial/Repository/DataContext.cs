using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;

namespace Shopping_Tutorial.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProductModel>().ToTable("Products");
            modelBuilder.Entity<Models.BrandModel>().ToTable("Brands");
            modelBuilder.Entity<Models.CategoryModel>().ToTable("Categories");
        }*/
    }
}
