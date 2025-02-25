using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    public class Course_Instructor
    {
        public int CourseId { get; set; }
       // public virtual Course Course { get; set; }

        public int InstructorId { get; set; }
       // public virtual Instructor Instructor { get; set; }

        public decimal Evaluate { get; set; }

    }
}
