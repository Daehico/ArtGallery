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
    public class AdminController : Controller
    {
        ArtContext db = new ArtContext();
        public ActionResult ListArts()
        {
            return View(db.ArtWorks);
        }

        public ViewResult EditArts(int Id)
        {
            ArtWork artWork = db.ArtWorks.FirstOrDefault(a => a.Id == Id);
            return View(artWork);
        }

        [HttpPost]
        public ActionResult EditArts(ArtWork artWork)
        {
            db.Entry(artWork).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ArtWork artWork)
        {
            db.ArtWorks.Add(artWork);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }
    }
}