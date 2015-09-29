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
        public ActionResult Index()
        {
            var studentList = _studentServices.Get(x=>x.Id==1);
            return View();
        }
    }
}