using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    public class EngineeringAndPrototypingCentersDbContext : DbContext
    {
        private const string _default_schema = "EngineeringAndPrototypingCenters";

        public DbSet<Company> Companies { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<FullName> FullNames { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Okved> Okveds { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ShortDescription> ShortDescriptions { get; set; }


        public EngineeringAndPrototypingCentersDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(_default_schema);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=10.36.201.108;" +
                "Port=31546;" +
                "Database=ClusterMembers;" +
                "Username=postgres;" +
                "Password=5uRjQa4z32;");

            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
