using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Model.Entities
{
    public class Course : Entity<int>
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
            CourseTutor = new Tutor();
            CourseSubject = new Subject();
        }

        public virtual string Name { get; set; }
        public virtual Double Duration { get; set; }
        public virtual string Description { get; set; }
        public virtual int CourseTutorId { get; set; }
        public virtual int CourseSubjectId { get; set; }
        public virtual Tutor CourseTutor { get; set; }
        public virtual Subject CourseSubject { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
