using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Model.Entities
{
    public interface IEntity<TPKey>
    {
        TPKey Id { get; set; }
    }
    public abstract class Entity<TPKey> : IEntity<TPKey>
    {
        public virtual TPKey Id { get; set; }
    }
}
