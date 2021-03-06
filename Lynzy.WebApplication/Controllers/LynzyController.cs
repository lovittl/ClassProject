﻿using Lynzy.Domain.Abstract;
using Lynzy.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lynzy.WebApplication.Controllers
{
    public class LynzyController : Controller
    {
        private ISongRepository DB = new EFSongRepository();
        // GET: Lynzy
        public ActionResult Index(int songId = 1)
        {
            ViewBag.currentSongName = DB.Song
                                        .Where(s => s.SID == songId)
                                        .Select(s => s.Name)
                                        .FirstOrDefault();
            return View(DB.Song);
        }
    }
}