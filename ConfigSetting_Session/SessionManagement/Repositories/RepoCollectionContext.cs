using Core.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SessionManagement.Models;

namespace Core.Repositories
{
    public class RepoCollectionContext:DbContext
    {
        public DbSet<Flower> Flowers{get;set;}
        public DbSet<Fruit> Fruits {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<User> Users {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "server=localhost;database=onlineshopping;user=root;password='password'";
            optionsBuilder.UseMySql(
                conString,
            ServerVersion.AutoDetect(conString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Flower>(entity => {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name);
                entity.Property(e => e.SalePrice);
                entity.Property(e => e.UnitPrice);
                entity.Property(e => e.Quantity);
            });
            modelBuilder.Entity<Fruit>(entity => {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.MovieName);
                entity.Property(e => e.Quantity);
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.OrderDate);
                entity.Property(e => e.Status);
                entity.Property(e => e.TotalAmount);
                entity.HasOne(e => e.User).WithMany(o => o.Orders);
            });

            modelBuilder.Entity<Order>()
            .HasOne(e => e.User)
            .WithMany(d => d.Orders)
            .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<User>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Location).IsRequired();
                entity.Property(e => e.ContactNumber).IsRequired();
                entity.Property(e => e.Password).IsRequired();
            });
        }
    }
}