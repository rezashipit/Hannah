using Chaos.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Model
{
   public class PassengerModel
    {
        public string Name { get; set; }
        public string Suname { get; set; }
        public Gender Gender { get; set; }
        public long SourceLat { get; set; }
        public long SourceLng { get; set; }
        public long DestinatopnLat { get; set; }
        public long DestionationLng { get; set; }
        public List<DateTime> GoTime { get; set; }
        public List<DateTime> ReturnTime { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }

    }
}
