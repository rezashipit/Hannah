using eLearning.Core.Attributes;
using eLearning.Core.Services;
using eLearning.Model.Entities;
using eLearning.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace eLearning.Web.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        public IHttpActionResult Get()
        {
            var z = _studentServices.Get().ToList();
            return Ok();
        
        }

    }
}