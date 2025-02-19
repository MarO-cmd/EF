using EF_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(D => D.Id);

            // Instructor FK
            builder.HasOne(D => D.Instructor)
                    .WithOne(I => I.Department)
                    .HasForeignKey<Department>(D => D.Inst_Id);
                   


            builder.Property(D => D.Id).UseIdentityColumn(1, 1);

            builder.Property(D => D.Name).HasMaxLength(50)
                                         .HasColumnType("varchar")
                                         .IsRequired(false);

            builder.Property(D => D.Hiring_Date).HasColumnType("DATETIME");


        }
    }
}
