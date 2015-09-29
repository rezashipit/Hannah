using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Model.Entities
{
    public class Subject : Entity<int>
    {
        public Subject()
        {
            Courses = new List<Course>();
        }

        public virtual string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
