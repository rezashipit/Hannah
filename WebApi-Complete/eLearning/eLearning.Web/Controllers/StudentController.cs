using Chaos.Core.Attributes;
using Chaos.Core.Services;
using Chaos.Model.Entities;
using Chaos.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Chaos.Web.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentServices;
        public StudentController(IStudentService studentServices)
        {
            _studentServices = studentServices;
        }
        [UnitOfWorkAttribute]
        public virtual IHttpActionResult Get()
        {
            var z = _studentServices.Get(x=>x.Id!=0).ToList();
            return Ok();
        
        }

    }
}