using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using validate.Models;

namespace validate.Controllers
{
    public class HomeController : Controller
    {
        public List<User> users = new List<User>();
        public ActionResult Index()
        {
            return View(users);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Detail(User user)
        {
            return View(user);
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
    
            users.Add(user);
            return View("Detail",user);
        }
    }
}