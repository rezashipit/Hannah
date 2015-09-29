using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Model.Entities
{
   public class Student:Entity<int>
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Enums.Gender Gender { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual DateTime? RegistrationDate { get; set; }
        public virtual DateTime? LastLoginDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
