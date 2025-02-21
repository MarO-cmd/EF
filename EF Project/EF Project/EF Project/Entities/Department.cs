using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hiring_Date { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Instructor{ get; set; }




    }

}
