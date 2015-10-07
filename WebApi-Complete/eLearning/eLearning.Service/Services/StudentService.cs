using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Chaos.Model.Entities;
using Chaos.Core.Repository;
using Chaos.Core.Services;
using Chaos.Core.Attributes;

namespace Chaos.Service.Services
{
    public class StudentService : ServiceBase<Students,int>,IStudentService
    {
        private readonly IStudentRepository _studentRepo;
        public StudentService(IStudentRepository studentRepo)
        {
            repo = studentRepo;
        }
    }
}
