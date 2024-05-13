using Microsoft.EntityFrameworkCore;
using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Models.Context
{
    public class MovieProjectContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=DESKTOP-J4PTH70;database=MovieProjectDB;uid=sa;pwd=123;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(x => x.Title).HasMaxLength(255);
            modelBuilder.Entity<Movie>().Property(x => x.Description).HasMaxLength(500);

            base.OnModelCreating(modelBuilder);
        }
    }   
}
