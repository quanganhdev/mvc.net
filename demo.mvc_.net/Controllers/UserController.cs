using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.mvc_.net.Controllers
{
public class UserController : Controller
{
    // GET: User
    public ActionResult Index()
    {

        ViewData["message"] = "user 1 viewdata";
        ViewBag.message = "viewbag";
        return View();
    }
    public ActionResult detail() {
        var product =new string[]{"iphone", "window"};

        return View();
    }
   
}
}
    