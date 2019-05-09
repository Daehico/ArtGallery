using Gallery1.Models;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class HomeController : Controller
    {
        ArtContext db = new ArtContext();
        public int pageSize = 12;

        public ActionResult Index(int? page, string searchBy, string search, string type)
        {
            var arts = db.ArtWorks
                .Include(a => a.Author)
                .Include(a => a.Type)
                .Include(a => a.Location.TypeLocation)
                .Include(a => a.Location.City.Country)
                .Include(a=> a.PhotoArt)
                .Include(a => a.Genre);
            //кнопки жанров
            if(type != null)
            {
                return View(arts.Where(x => x.Type.TypeName.StartsWith(type))
                .ToList().ToPagedList(page ?? 1, pageSize));
            }
            //пользовательский поиск по жанру
            if(searchBy == "Type")
            {
                return View(arts
                    .Where(x => x.Type.TypeName.StartsWith(search) || search == null)
                    .ToList().ToPagedList(page ?? 1, pageSize));
            }
            else //пользовательский поиск по названию
            {
                return View(arts
                    .Where(x => x.WorkName.StartsWith(search) || search == null)
                    .ToList().ToPagedList(page ?? 1, pageSize));
            }  
        }

        public ViewResult ViewArt(int? Id)
        {
            ArtWork artWork = db.ArtWorks
                .Include(a => a.Author)
                .Include(a => a.Type)
                .Include(a => a.Location.TypeLocation)
                .Include(a => a.Location.City.Country)
                .Include(a => a.PhotoArt)
                .Include(a => a.Genre)
                .FirstOrDefault(a => a.Id == Id);
            //ArtWork artWork = db.ArtWorks.FirstOrDefault(a => a.Id == Id);
            return View(artWork);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}