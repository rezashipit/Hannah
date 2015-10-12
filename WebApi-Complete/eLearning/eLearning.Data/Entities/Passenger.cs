using Chaos.Data.Entities;
using Chaos.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Model.Entities
{
    public class Passenger : Entity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Suname { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual long SourceLat { get; set; }
        public virtual long SourceLng { get; set; }
        public virtual long DestinatopnLat { get; set; }
        public virtual long DestionationLng { get; set; }
        public virtual IList<TravelTime> TravelTime { get; set; }
        public virtual string Email { get; set; }
        public virtual string Country { get; set; }
        public virtual string City { get; set; }
        public virtual string Suburb { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Password { get; set; }
        public virtual List<Prefrence> Prefers { get; set; }
        public virtual IList<ExceptionDay> ExceptionDays { get; set; }


    }
}
