using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Repositories
{
    public class CollectionContext : DbContext
    {

        public DbSet<Products> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectString = "server=localhost;port=3306;database=practice;username=root;password=mayu1525";
            optionsBuilder.UseMySQL(connectString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>(Entity =>
            {
                Entity.HasKey(p=>p.Id);
                Entity.Property(p=>p.Title).IsRequired();
                Entity.Property(p=>p.Description).IsRequired();
                Entity.Property(p=>p.UnitPrice).IsRequired();
                Entity.Property(p=>p.ImageUrl).IsRequired();
                Entity.Property(p=>p.Quantity).IsRequired();
            }
            );

            modelBuilder.Entity<Products>().ToTable("Product");
        }
    }
   
    
}
