using Chaos.Model.Entities;
using Chaos.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Core.Repository
{
   public interface IStudentRepository:IChaosRepository<Students,int>
    {
    }
}
