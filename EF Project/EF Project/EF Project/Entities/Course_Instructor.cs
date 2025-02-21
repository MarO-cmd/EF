using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    internal class Course_Instructor
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public decimal Evaluate { get; set; }

    }
}
