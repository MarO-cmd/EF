﻿using EF_Project.Entities;
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

           

            //builder.HasMany(D => D.Instructors)
            //       .WithOne(I => I.WorkDepartment)
            //       .HasForeignKey(I => I.WorkDepartmentId);



            builder.Property(D => D.Id).UseIdentityColumn(1, 1);

            builder.Property(D => D.Name).HasMaxLength(50)
                                         .HasColumnType("varchar")
                                         .IsRequired(false);

            builder.Property(D => D.Hiring_Date).HasColumnType("DATETIME");


        }
    }
}
