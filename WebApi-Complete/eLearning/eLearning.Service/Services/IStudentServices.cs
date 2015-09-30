using eLearning.Core.Attributes;
using eLearning.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Service.Services
{
    public interface IStudentServices
    {
         void Create(Students entity);
        void Delete(Students entity);

        void Update(Students entity);
      
        IEnumerable<Students> Get(Expression<Func<Students, bool>> predication=null);

    }
}
