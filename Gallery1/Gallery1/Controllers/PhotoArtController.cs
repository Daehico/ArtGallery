using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class PhotoArtController : Controller
    {

        [HttpGet]
        public ActionResult UploadPhoto()
        {
            return View();
        }

        public ActionResult UploadPhoto(HttpPostedFileBase upload)
        {
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
                }
            }

            return RedirectToAction("UploadPhoto");
        }
    }
}