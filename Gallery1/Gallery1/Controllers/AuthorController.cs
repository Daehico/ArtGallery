using Gallery1.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class AuthorController : Controller
    {
        ArtContext db = new ArtContext();
        public int pageSize = 15;
        public ActionResult ListOfAuthors(int? page, string searchBy, string author)
        {
            var arts = db.Authors;
            RedirectToAction("Index", "Home", new { searchBy = "Author" });
            return View(arts.ToList().ToPagedList(page ?? 1, pageSize));
        }
    }
}