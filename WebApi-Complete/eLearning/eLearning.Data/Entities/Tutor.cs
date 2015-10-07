using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Model.Entities
{
   public class Tutor:Entity<int>
    {
        public Tutor()
        {
            Courses = new List<Course>();
        }
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Enums.Gender Gender { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
