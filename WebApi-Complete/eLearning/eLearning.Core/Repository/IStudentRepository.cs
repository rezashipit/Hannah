using eLearning.Model.Entities;
using eLearning.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Core.Repository
{
   public interface IStudentRepository:IeLearningRepository<Students,int>
    {
    }
}
