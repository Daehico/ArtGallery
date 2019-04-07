using Gallery1.Abstract;
using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Type = Gallery1.Models.Type;

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
        [HttpGet]
        public ActionResult DeleteArt(int id)
        {
           ArtWork b = db.ArtWorks.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
       
        [HttpPost, ActionName("DeleteArt")]
        public ActionResult DeleteConfirmed(int id)
        {
           ArtWork b = db.ArtWorks.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.ArtWorks.Remove(b);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateType(Type type)
        {
            db.Types.Add(type);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAuthor(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }
       
        [HttpGet]
        public ActionResult CreateGenre()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateGenre(Genre genre)
        {
            db.Genres.Add(genre);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateSchool()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSchool(School school)
        {
            db.Schools.Add(school);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateTechnique()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTechnique(Technique technique)
        {
            db.Techniques.Add(technique);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateLocation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLocation(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCity(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCountry(Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }
    }
}