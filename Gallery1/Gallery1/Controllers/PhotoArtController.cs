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
        // GET: PhotoArt
        //public ActionResult UploadPhoto()
        //{
        //    return View();
        //}
        private void CheckUserRights(int id)
        {
            if (id == 0)
            {
                throw new HttpException(404, "облом");
            }
        }

        [HttpGet]
        public ActionResult UploadPhoto(int userid)
        {
            CheckUserRights(userid);
            return View();
        }

        public ActionResult UploadPhoto(int userid, HttpPostedFileBase upload)
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
                    //ArtWork artWork = db1.ArtWorks.Where(p => p.Id == Id).FirstOrDefault();
                    //artWork.PhotoArtId = photoId;
                    //db1.SaveChanges();
                }
            }
          
            return RedirectToAction("UploadPhoto");
        }
    }
}