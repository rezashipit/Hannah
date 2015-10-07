using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Core.Services
{
    public interface IChaosService
    { }
    public interface IChaosService<T,P>:IChaosService
    {
        void Create(T entity);
        void Delete(T entity);

        void Update(T entity);

        IList<T> Get(Expression<Func<T, bool>> predication);

    }
    public interface IStudentService : IChaosService<Students,int>
    {

    }
}
