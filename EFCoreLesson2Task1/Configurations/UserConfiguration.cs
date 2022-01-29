using EFCoreLesson2Task1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task1.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");   
            builder.HasKey(u => u.UserID);
            builder.HasOne(u => u.UserInfo).WithOne(u => u.User).HasForeignKey<UserInfo>(u=>u.UserID).OnDelete(DeleteBehavior.Cascade); // One to one
            builder.Property(u => u.PassNo).HasColumnType("varchar(20)");
            builder.Property(u => u.Name).HasColumnType("varchar(20)");

        }
    }
}
