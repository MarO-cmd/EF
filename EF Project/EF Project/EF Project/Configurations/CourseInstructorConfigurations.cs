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
    internal class CourseInstructorConfigurations : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            builder.HasKey(CI => new { CI.CourseId, CI.InstructorId });
        }
    }
}
