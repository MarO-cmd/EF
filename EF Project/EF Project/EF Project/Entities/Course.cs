using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Duration { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student_Course> Students{ get; set; }

        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }

        public virtual ICollection<Course_Instructor> TeachedBy{ get; set; }


    }
}
