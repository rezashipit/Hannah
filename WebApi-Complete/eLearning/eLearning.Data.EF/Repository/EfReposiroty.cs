using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Model.Repository;
using eLearning.Model.Entities;
using System.Linq.Expressions;
using eLearning.Data.EF.DatabaseContext;


namespace eLearning.Data.EF.Repository
{
    public abstract class EfReposiroty<T, P> : IeLearningRepository<T, P> where T : Entity<P>
    {


        IEnumerable<T> IeLearningRepository<T, P>.GetAll()
        {
            using (var db = new LearningContext())
            {
                IQueryable<T> z= db.Set<T>();
                var a = z.Select(x => x.Id);
                return z;
                
            }
                
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            using (var db = new LearningContext())
            {
                IEntity<int> n = new Student();
                    
                //var kk = db.Students.Add();
                var z = db.Set<T>();

                return null;

            }
        }

        void IeLearningRepository<T, P>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> predicate)
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
