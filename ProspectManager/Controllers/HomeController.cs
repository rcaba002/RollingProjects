﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProspectManager.Models.Home;

namespace ProspectManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            var model = new IndexViewModel { 
                Id = id.GetValueOrDefault()
            };

            return View(model);
        }
    }
}