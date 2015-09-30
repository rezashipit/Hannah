using eLearning.Core.Services;
using eLearning.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearning.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentServices _studentServices;
        public HomeController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
