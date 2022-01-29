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
    internal class WorkerInfoConfiguration : IEntityTypeConfiguration<WorkerInfo>
    {
        public void Configure(EntityTypeBuilder<WorkerInfo> builder)
        {
            
        }
    }
}
