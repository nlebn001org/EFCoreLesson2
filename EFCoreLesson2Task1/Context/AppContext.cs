using EFCoreLesson2Task1.Configurations;
using EFCoreLesson2Task1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task1.Context
{
    internal class AppContext : DbContext
    {
        public AppContext() => Database.EnsureCreated();

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserInfo> UserInfo { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=EFCoreLesson2Task1;trusted_connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserInfoConfiguration());
        }
    }
}
