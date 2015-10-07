using Chaos.Data.Nh.UnitOfWork;
using Chaos.Model.Entities;
using Chaos.Core.Repository;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using Chaos.Core.Attributes;

namespace Chaos.Data.Nh.Repository
{
   public abstract class NhRepositoryBase<T,P>:IChaosRepository<T,P> where T:Entity<P>
    {
       protected ISession Session { get { return NhUnitOfWork.Current.Session; } }
       [UnitOfWorkAttribute]
       public virtual IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            return Session.Query<T>().ToList();
        }

       [UnitOfWorkAttribute]
       public virtual IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Session.Query<T>().Where(predicate);
        }

        public T Get(P id)
        {
            return Session.Query<T>().FirstOrDefault(x=>x.Id.Equals(id));
        }

        public void Delete(T id)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
