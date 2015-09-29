using eLearning.Core.Attributes;
using eLearning.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Service
{
    public interface IStudentServices
    {
         void Create(Students entity);
        void Delete(Students entity);

        void Update(Students entity);
      
        IQueryable<Students> Get(Expression<Func<Students, bool>> predication=null);

    }
}
