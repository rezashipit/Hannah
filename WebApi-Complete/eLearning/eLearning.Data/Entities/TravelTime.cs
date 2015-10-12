using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Entities
{
   public class TravelTime:Entity<int>
    {
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual DateTime GoingTime { get; set; }
        public virtual DateTime ReturnTime { get; set; }
    }
}
