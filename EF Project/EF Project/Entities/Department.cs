using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hiring_Date { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public int MangerId { get; set; }
        public virtual Instructor Manger{ get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }




    }

}
