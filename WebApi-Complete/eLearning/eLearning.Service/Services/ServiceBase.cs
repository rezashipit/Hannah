using Chaos.Core.Attributes;
using Chaos.Core.Repository;
using Chaos.Core.Services;
using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Service.Services
{
    public interface IServiceBase<T>
    {
        void Create(T entity);
        void Delete(T entity);

        void Update(T entity);

        IEnumerable<T> Get(Expression<Func<T, bool>> predication = null);
    }
    public abstract class ServiceBase<T, P> : IChaosService<T,P> where T : Entity<P>
    {
        public IChaosRepository<T,P> repo { get; set; }

        public void Create(T entity)
        {
            repo.Add(entity);
        }

        public void Delete(T entity)
        {
            repo.Delete(entity);
        }

        public void Update(T entity)
        {
            repo.Update(entity);
        }
        [UnitOfWorkAttribute]
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predication = null)
        {
            return repo.GetAll(predication);

        }


        [UnitOfWorkAttribute]
        IList<T> IChaosService<T, P>.Get(Expression<Func<T, bool>> predication)
        {
            return repo.Get(predication).ToList();
        }
    }
}
