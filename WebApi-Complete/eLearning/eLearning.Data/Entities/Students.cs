﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Model.Entities
{
    public class Students : Entity<int>
    {
        public Students()
        {
            Enrollments = new List<Enrollment>();
        }
        private Enums.Gender _Gender;


        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Enums.Gender Gender
        {
            get { return _Gender; }

            set
            {
                _Gender = (Enums.Gender)value;
            }

        }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual DateTime? RegistrationDate { get; set; }
        public virtual DateTime? LastLoginDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
