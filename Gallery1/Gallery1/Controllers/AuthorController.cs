﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult ListOfAuthors()
        {
            return View();
        }
    }
}