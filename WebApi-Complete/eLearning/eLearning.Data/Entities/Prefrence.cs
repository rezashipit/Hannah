using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Entities
{
    public class Prefrence:Entity<int>
    {
        public virtual string Detail { get; set; }
    }
}
