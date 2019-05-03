using Gallery1.Abstract;
using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            return View(db.ArtWorks
                .Include(a => a.Type)
                .Include(a => a.Author)
                .Include(a => a.Genre)
                .Include(a => a.Location)
                .Include(a => a.Technique));
        }

        public ViewResult EditArts(int Id)
        {
            EditModel model = new EditModel();
            using (ArtContext db = new ArtContext())
            {
                model.ArtWorks = db.ArtWorks.FirstOrDefault(a => a.Id == Id);
                model.Authors = db.Authors.ToList();
                model.PhotoArt = db.PhotoArts.FirstOrDefault(a => a.Id == Id);
                model.AuthorsCollection = db.Authors.ToList();
                model.TypesCollection = db.Types.ToList();
                model.GenresCollection = db.Genres.ToList();
                model.TechniquesCollection = db.Techniques.ToList();
                model.LocationsCollection = db.Locations.ToList();
               
            }
            ArtWork artWork = db.ArtWorks.Include(a => a.Author)
               .FirstOrDefault(a => a.Id == Id);
           

            return View(model);
            //using (ArtContext db = new ArtContext())
            //{
            //    var model = new EditModel
            //    {
            //        ArtWorks = db.ArtWorks.FirstOrDefault(a => a.Id == Id),
            //        Authors = db.Authors.ToList(),
            //        PhotoArt = db.PhotoArts.FirstOrDefault(a => a.Id == Id),
            //        AuthorsCollection = db.Authors.ToList<Author>();
            //    };
            //    return View(model);
            //}
           
        }

        [HttpPost]
        public ActionResult EditArts(EditModel editModel, HttpPostedFileBase upload, int Id)
        {
            
                
                using (ArtContext db1 = new ArtContext())
                {
                if (upload != null)
                {
                    string fileName = System.IO.Path.GetFileName(upload.FileName);
                    upload.SaveAs(Server.MapPath("~/Files/" + fileName));
                    int photoId;
                    PhotoArt photo = new PhotoArt { PhotoName = fileName, Photo = Server.MapPath("~/ Files / " + fileName) };
                    db1.PhotoArts.Add(photo);
                    db1.SaveChanges();
                    //db1.PhotoArtCollection.Add(p1);
                    //db1.PhotoArts.Add(p1);

                    photoId = photo.Id;
                    ArtWork artWork = db1.ArtWorks.Where(p => p.Id == Id).FirstOrDefault();
                    artWork.PhotoArtId = photoId;
                    db1.SaveChanges();
                }
                else
                {

                    ArtWork artWork = db1.ArtWorks.FirstOrDefault(a => a.Id == Id);
                    db1.ArtWorks.AddOrUpdate(artWork);

                    db1.Entry(artWork).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
           
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