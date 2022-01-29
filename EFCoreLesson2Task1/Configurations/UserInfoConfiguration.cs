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
    internal class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.ToTable("UserInfo");
            builder.HasKey(u=>u.UserInfoID);
            builder.Property(u => u.Address).HasColumnType("varchar(20)");
            builder.Property(u => u.City).HasColumnType("varchar(20)");
            builder.Property(u => u.Phone).HasColumnType("varchar(20)");
            builder.Property(u => u.Address).HasColumnType("varchar(20)");
        }
    }
}
