using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using eLearning.Model.Entities;
using eLearning.Core.Repository;
using eLearning.Core.Services;
using eLearning.Core.Attributes;

namespace eLearning.Service.Services
{
    public class StudentService : IStudentServices
    {
        private readonly IStudentRepository _studentRepo;
        public StudentService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public void Create(Students entity)
        {
            _studentRepo.Add(entity);
        }

        public void Delete(Students entity)
        {
            _studentRepo.Delete(entity);
        }

        public void Update(Students entity)
        {
            _studentRepo.Update(entity);
        }
        [UnitOfWork]
        public virtual IQueryable<Students> Get(Expression<Func<Students, bool>> predication=null)
        {
            return _studentRepo.GetAll(predication);
        }
    }
}
