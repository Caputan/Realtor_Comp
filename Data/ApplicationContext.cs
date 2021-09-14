using RieltorComp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RieltorComp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Users> Users { get; set; }

        // public ApplicationContext()
        // {
        //     Database.EnsureCreated();
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = RieltorBD.db");
        }

    }
}