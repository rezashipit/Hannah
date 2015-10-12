using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Entities
{
    public class ExceptionDay:Entity<int>
    {
        public virtual bool IsOff { get; set; }
        public virtual DateTime GoTime { get; set; }
        public virtual DateTime ReturnTime { get; set; }
    }
}
