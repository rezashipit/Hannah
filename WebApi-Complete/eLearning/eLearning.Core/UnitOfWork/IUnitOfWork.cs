using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Core.UnitOfWork
{
   public interface IUnitOfWork
    {
       void BeginTransaction();
       void Commit();
       void Rollback();
    }
}
