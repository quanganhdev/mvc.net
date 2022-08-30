using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ams2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData ["Name"] = "quang anh";
            TempData["Age"] = 23;
            TempData["Address"] = "my duc, ha noi"; 
            return View("ShowData");
        }
        public ActionResult ShowData()
        {
            return View();
        }
    }
}