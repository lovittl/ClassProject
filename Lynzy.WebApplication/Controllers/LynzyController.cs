using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lynzy.WebApplication.Controllers
{
    public class LynzyController : Controller
    {
        // GET: Lynzy
        public ActionResult Index()
        {
            return View();
        }
    }
}