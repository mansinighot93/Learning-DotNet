using Microsoft.EntityFrameworkCore;
//using MySql.Data.EntityFrameworkCore.Extension;

namespace MySqlTestApp
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book> Book{get;set;}
        public DbSet<Publisher> Publisher{get;set;}
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
            modelBuilder.Entity<Publisher>(entity => 
            {
                entity.HasKey(entity => entity.ID);
                entity.Property(entity => entity.Name).IsRequired();
            });
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ISBN);
                entity.Property(e => e.Title).IsRequired();
                entity.HasOne(d => d.Publisher).WithMany(p => p.Books);
            });
        }
    }
}