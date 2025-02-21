using EF_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Configurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(C => C.Id);

            // topic FK
            builder.HasOne(C => C.Topic)
                   .WithMany(T => T.courses)
                   .HasForeignKey(C => C.TopicId);
          

            builder.Property(C => C.Id).UseIdentityColumn(1, 1);

            builder.Property(C => C.Name).HasMaxLength(50)
                                         .HasColumnType("varchar")
                                         .IsRequired(false);

            builder.Property(C => C.Description).HasMaxLength(50)
                                                .HasColumnType("varchar")
                                                .IsRequired();

           


        }
    }
}
