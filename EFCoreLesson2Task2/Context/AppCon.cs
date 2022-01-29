using EFCoreLesson2Task2.Configurations;
using EFCoreLesson2Task2.Entites;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCoreLesson2Task2.Context
{
    internal class AppCon : DbContext
    {
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<WorkerInfo> WorkersInfo { get; set; } = null!;

        public AppCon() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=EFCoreLesson2Task2;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkerConfiguration());
            modelBuilder.ApplyConfiguration(new WorkerInfoConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        }

    }
}
