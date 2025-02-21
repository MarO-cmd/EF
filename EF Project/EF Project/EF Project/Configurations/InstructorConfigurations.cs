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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I => I.Id);

            builder.Property(I => I.Id).UseIdentityColumn(1, 1);


            // Department FK
            builder.HasOne(I => I.Department)
                   .WithOne(D => D.Instructor)
                   .HasForeignKey<Instructor>(I => I.DepartmentId);



            builder.Property(I => I.Name).HasMaxLength(50)
                                         .HasColumnType("varchar")
                                         .IsRequired(false);
                
            builder.Property(I => I.salary).HasColumnType("decimal(18,4)");


            builder.Property(I => I.Adress).HasMaxLength(50)
                                           .HasColumnType("varchar")
                                           .IsRequired(false);





        }
    }
}
