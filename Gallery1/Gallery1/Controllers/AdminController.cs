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

        private void CheckUserRights(int id)
        {
            if(id == 0)
            {
                throw new HttpException(404, "облом");
            }
        }

        [Authorize(Roles = "Администратор")]
        public ActionResult ListArts(int id)
        {
                CheckUserRights(id);
                return View(db.ArtWorks
                .Include(a => a.Type)
                .Include(a => a.Author)
                .Include(a => a.Genre)
                .Include(a => a.Location)
                .Include(a => a.Technique));
            }
            
        

        public ActionResult EditArts(int Id,int userid)
        {
        CheckUserRights(userid);
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
                    model.PhotoArtCollection = db.PhotoArts.ToList();
                }
                return View(model);
            }
           
        

        [HttpPost]
        public ActionResult EditArts(EditModel model, HttpPostedFileBase upload, int Id, int userid)
        {
            CheckUserRights(userid);
            if (upload != null)
                {
                    string fileName = System.IO.Path.GetFileName(upload.FileName);
                    upload.SaveAs(Server.MapPath("~/Files/" + fileName));
                    int photoId;
                    using (ArtContext db1 = new ArtContext())
                    {
                        PhotoArt p1 = new PhotoArt { PhotoName = fileName, Photo = Server.MapPath("~/ Files / " + fileName) };
                        db1.PhotoArts.Add(p1);
                        db1.SaveChanges();
                        photoId = p1.Id;
                        ArtWork artWork = db1.ArtWorks.Where(p => p.Id == Id).FirstOrDefault();
                        artWork.PhotoArtId = photoId;
                        db1.SaveChanges();
                    }
                }
                else
                {
                    db.Entry(model.ArtWorks).State = EntityState.Modified;
                    db.SaveChanges();
                }
            
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult UploadPhoto(int userid)
        {
            CheckUserRights(userid);
            return View();
        }

        [HttpPost]
        public ActionResult UploadPhoto(PhotoArt photo, HttpPostedFileBase upload, int userid)
        {
            CheckUserRights(userid);
            if (upload != null)
            {
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                upload.SaveAs(Server.MapPath("~/Files/" + fileName));
                using (ArtContext db = new ArtContext())
                {
                    PhotoArt p1 = new PhotoArt { PhotoName = fileName, Photo = Server.MapPath("~/ Files / " + fileName) };
                    db.PhotoArts.Add(p1);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult Create(int userid)
        {
            CheckUserRights(userid);
            return View();
        }

        [HttpPost]
        public ActionResult Create(ArtWork artWork,int userid)
        {
            CheckUserRights(userid);
            db.ArtWorks.Add(artWork);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult DeleteArt(int id, int userid)
        {
            CheckUserRights(userid);
            ArtWork b = db.ArtWorks.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }

        [HttpPost, ActionName("DeleteArt")]
        public ActionResult DeleteConfirmed(int id,int userid)
        {
            CheckUserRights(userid);
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
        public ActionResult CreateType(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateType(Type type,int userid)
        {
            CheckUserRights(userid);
            db.Types.Add(type);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateAuthor(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateAuthor(Author author,int userid)
        {
            CheckUserRights(userid);
            db.Authors.Add(author);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateGenre(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateGenre(Genre genre,int userid)
        {
            CheckUserRights(userid);
            db.Genres.Add(genre);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }


        [HttpGet]
        public ActionResult CreateTechnique(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateTechnique(Technique technique,int userid)
        {
            CheckUserRights(userid);
            db.Techniques.Add(technique);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateLocation(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateLocation(Location location,int userid)
        {
            CheckUserRights(userid);
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateCity(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateCity(City city,int userid)
        {
            CheckUserRights(userid);
            db.Cities.Add(city);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }

        [HttpGet]
        public ActionResult CreateCountry(int userid)
        {
            CheckUserRights(userid);
            return View();
        }
        [HttpPost]
        public ActionResult CreateCountry(Country country, int userid)
        {
            CheckUserRights(userid);
            db.Countries.Add(country);
            db.SaveChanges();
            return RedirectToAction("ListArts");
        }
    }
}