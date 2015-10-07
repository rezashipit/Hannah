using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Core.Repository
{
    public interface IChaosRepository
    { }
    public interface IChaosRepository<T, P> : IChaosRepository where T : IEntity<P>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T Get(P id);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);

    }
}
