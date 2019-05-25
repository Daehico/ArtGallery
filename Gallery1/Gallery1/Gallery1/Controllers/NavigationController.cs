using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class NavigationController : Controller
    {
        ArtContext db = new ArtContext();
        public PartialViewResult Menu(string type = null)
        {
            ViewBag.SelectedTypes = type;

            IEnumerable<string> types = db.ArtWorks
                .Select(art => art.Type.TypeName)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(types);
        }
    }
}