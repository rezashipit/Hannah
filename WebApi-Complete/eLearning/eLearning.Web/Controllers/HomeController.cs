using Chaos.Core.Services;
using Chaos.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chaos.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _studentServices;
        public HomeController(IStudentService studentServices)
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
