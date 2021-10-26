using Microsoft.EntityFrameworkCore;
using LIAECommerce.Models;


namespace LIAECommerce.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {}
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity => {
                entity.HasKey(e => e.ProductId)
                    .HasName("product_id");
                entity.ToTable("oc_product", "storedemo");

                entity.Property(e => e.Points)
                .HasColumnType("int")
                .HasColumnName("points"); 
            });
            modelBuilder.Entity<ProductDescription>(entity => {
                entity.HasKey(e => e.ProductId)
                    .HasName("product_id");
                entity.ToTable("oc_product_description", "storedemo");

                entity.Property(e => e.Name)
                .HasColumnType("string")
                .HasColumnName("name");
            });

        }
    }
}
