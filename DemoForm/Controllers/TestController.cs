using DemoForm.Models.Entities;
using System.Web.Mvc;

namespace DemoForm.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult AddEmp(Emp emp)
        //{
        //    using (var dbContext = new TestEntities())
        //    {
        //        dbContext.Emps.Add(emp);
        //        dbContext.SaveChanges();
        //        return RedirectToAction("AddEmp");
        //    }

        //}

        [HttpPost]
        public ActionResult AddEmp(string name, string phoneNumber, string address)
        {
            Emp emp = new Emp() {Address = address, Name = name, PhoneNumber = phoneNumber};
            using (var dbContext = new TestEntities())
            {
                dbContext.Emps.Add(emp);
                dbContext.SaveChanges();
                return RedirectToAction("AddEmp");
            }
        }
    }
}