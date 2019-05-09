using Gallery1.Abstract;
using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class UserControlController : Controller
    {
        UserContext ub = new UserContext();
        public ActionResult ListUser()
        {
            return View(ub.Users);
        }

        public ActionResult EditUser(int Id)
        {
            User user = ub.Users.FirstOrDefault(a => a.Id == Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUser(User user)
        {
            ub.Entry(user).State = EntityState.Modified;
            ub.SaveChanges();
            return RedirectToAction("ListUser");
        }
    }
}