using Guestbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestbook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var entries = Data.List();

            return View(entries);
        }

        public ActionResult Checkin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Checkin(string firstName, string lastName)
        {
            Data.Add(firstName, lastName);
            return Redirect("/");
        }
    }
}