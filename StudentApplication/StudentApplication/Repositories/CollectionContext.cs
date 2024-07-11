using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using StudentApplication.Models;

namespace StudentApplication.Repositories
{
    public class CollectionContext:DbContext
    {
        public DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectstring = "server=localhost;port=3306;database=Lab;username=root;password=mayu1525;";
            optionsBuilder.UseMySQL(connectstring);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>(Entity =>
            {
                Entity.HasKey(s => s.Id);
                Entity.Property(s=>s.Name).IsRequired();
                Entity.Property(s=>s.email).IsRequired();
                Entity.Property(s=>s.phone).IsRequired();
                Entity.Property(s=>s.Address).IsRequired();
                Entity.Property(s => s.admission_date).HasConversion(v => v.ToDateTime(TimeOnly.MinValue), v => DateOnly.FromDateTime(v)).HasColumnType("admission_date");
                Entity.Property(s=>s.fees).IsRequired();
                Entity.Property(s=>s.status).IsRequired();  
            });
            modelBuilder.Entity<Students>().ToTable("Students");
        }
        
    }
}

