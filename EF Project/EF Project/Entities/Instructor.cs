using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public decimal salary { get; set; }
        public string Adress { get; set; }
        public int Hour_rate { get; set; }
        
        public virtual ICollection<Course_Instructor> Teach { get; set; }

        public int ManageDepartmentId { get; set; }
        public virtual Department ManageDepartment{ get; set; }

        public int WorkDepartmentId { get; set; }
        public virtual Department WorkDepartment  { get; set; }






    }
}
