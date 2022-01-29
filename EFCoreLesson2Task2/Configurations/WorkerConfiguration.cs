using EFCoreLesson2Task2.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task2.Configurations
{
    internal class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(w=>w.WorkerID);
            builder.HasOne(w => w.Company).WithMany(c => c.Workers)
                .HasForeignKey(w => w.CompanyID);
            builder.HasOne(w => w.WorkerInfo).WithOne(w => w.Worker);
        }
    }
}
