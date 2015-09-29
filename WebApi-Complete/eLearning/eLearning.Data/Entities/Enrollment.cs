using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Model.Entities
{
    public class Enrollment:Entity<int>
    {
        public Enrollment()
        {
            Student = new Students();
            Course = new Course();
        }
        public virtual DateTime EnrollmentDate { get; set; }
        public virtual Students Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
