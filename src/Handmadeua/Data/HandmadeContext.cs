using Handmadeua.Data.Models;
using Handmadeua.Data.Models.JoinedEntities;
using Microsoft.EntityFrameworkCore;

namespace Handmadeua.Data
{
    public class HandmadeContext : DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public HandmadeContext(DbContextOptions<HandmadeContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaterialProduct>()
                .HasKey(t => new { t.MaterialId, t.ProductId });

            modelBuilder.Entity<MaterialProduct>()
                .HasOne(sc => sc.Product)
                .WithMany(s => s.MaterialProducts)
                .HasForeignKey(sc => sc.ProductId);

            modelBuilder.Entity<MaterialProduct>()
                .HasOne(sc => sc.Material)
                .WithMany(c => c.MaterialProducts)
                .HasForeignKey(sc => sc.MaterialId);

            modelBuilder.Entity<ProductAuthor>()
                .HasKey(t => new { t.ProductId, t.AuthorId });

            modelBuilder.Entity<ProductAuthor>()
                .HasOne(sc => sc.Product)
                .WithMany(s => s.ProductAuthors)
                .HasForeignKey(sc => sc.ProductId);

            modelBuilder.Entity<ProductAuthor>()
                .HasOne(sc => sc.Author)
                .WithMany(c => c.ProductAuthors)
                .HasForeignKey(sc => sc.AuthorId);
        }
    }
}
