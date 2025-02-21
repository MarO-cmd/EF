using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Student_Course> Courses{ get; set; }

        public int Dept_Id { get; set; }
        public virtual Department Department { get; set; }

    }
}
