using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class AuctionController : Controller
    {
        ArtContext db = new ArtContext();
        public ActionResult auction()
        {
            return View();
        }
    }
}