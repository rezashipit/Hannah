using eLearning.Core.Attributes;
using eLearning.Core.Services;
using eLearning.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearning.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        [UnitOfWork]
        public virtual ActionResult Index()
        {
            var studentList = _studentServices.Get().ToList();
            return View();
        }
    }
}