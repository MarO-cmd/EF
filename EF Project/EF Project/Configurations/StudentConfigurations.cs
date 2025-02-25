using EF_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(S => S.Id);

            builder.Property(S => S.Id).UseIdentityColumn(1, 1);


            // Department FK
            builder.HasOne(S => S.Department)
                   .WithMany(D => D.Students)
                   .HasForeignKey(S => S.Dept_Id)
                   .IsRequired(false);

            builder.Property(I => I.FName).HasMaxLength(20)
                                         .HasColumnType("varchar")
                                         .IsRequired(false);

            builder.Property(I => I.LName).HasMaxLength(20)
                                        .HasColumnType("varchar")
                                        .IsRequired(false);

 

            builder.Property(I => I.Adress).HasMaxLength(50)
                                           .HasColumnType("varchar")
                                           .IsRequired(false);
        }
    }
}
