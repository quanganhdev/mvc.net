using demo_model.Models;
using System.Web.Mvc;

namespace demo_model.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        /*  public ActionResult Index(int Id,String FullName,String Email,String Phone,String Gender,String Address)
          {
              var student = new Student
              {
                  Id = Id,
                  FullName = FullName,
                  Email = Email,
                  Address = Address,
                  Gender = Gender,
                  Phone = Phone,

              };
              return View();
          } }*/
   public ActionResult Index(Student st)
      {
          var student = st;
            ViewBag.student= student;
          return View("detail");
      }
    }


    
}
