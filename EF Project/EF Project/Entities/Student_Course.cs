using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    public class Student_Course
    {
        public int StudentId { get; set; } // fk

        //public Student Student { get; set; } 

        public int CourseId { get; set; } // fk

        //public Course Course { get; set; }

        public decimal Grade { get; set; }

    }
}
