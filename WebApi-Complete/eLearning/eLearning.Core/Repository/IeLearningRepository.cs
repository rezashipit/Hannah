using eLearning.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Core.Repository
{
    public interface IeLearningRepository
    { }
    public interface IeLearningRepository<T,P> :IeLearningRepository where T:IEntity<P>
    { 
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate=null);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Get(P id);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);

    }
}
