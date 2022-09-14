using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo_model.Models;

namespace demo_model.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            var Student = new Student
            {
                Id = 1,
                FullName = "quang anh",
                Email = " quanganhle.dev@gmail.com",
                Address="my duc ",
                Phone="0212112",
                Gender="nam"
              
            };
            var Student2 = new Student
            {
                Id = 2,
                FullName = "quang anh le",
                Email = " quanganhle.dev@gmail.com",
                Address = "my duc ",
                Phone = "02ssadad12112",
                Gender = "nam"

            };
            students.Add(Student);
            students.Add(Student2);
            ViewBag.Students = students;
            return View();
        }
    }
}