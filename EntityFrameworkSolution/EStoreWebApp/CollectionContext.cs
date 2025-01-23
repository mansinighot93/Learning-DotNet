using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace EStoreWebApp
{
    public class CollectionContext:DbContext
    {
        public DbSet<Product> Products{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "server=localhost;database=learningapp;user=root;password='password'";
            optionsBuilder.UseMySql(
                conString,
            ServerVersion.AutoDetect(conString) // Auto-detects the MySQL server version
        );
        }        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });
        }
    }
}