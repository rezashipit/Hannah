using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using eLearning.Model.Entities;
using eLearning.Core.Repository;
using eLearning.Core.Services;

namespace eLearning.Service.Services
{
    public class StudentService:IStudentServices
    {
        private readonly IStudentRepository _studentRepo;
        public StudentService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo; 
        }
        public void Create(Student entity)
        {
            _studentRepo.Add(entity);
        }

        public void Delete(Student entity)
        {
            _studentRepo.Delete(entity);
        }

        public void Update(Student entity)
        {
            _studentRepo.Update(entity);
        }

        public IQueryable<Student> Get(Expression<Func<Student, bool>> predication)
        {
            return _studentRepo.GetAll(predication);
        }
    }
}
