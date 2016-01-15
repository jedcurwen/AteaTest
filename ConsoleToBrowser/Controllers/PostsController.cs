using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsoleToBrowser;

namespace ConsoleToBrowser.Controllers
{
    public class PostsController : Controller
    {
        public Entities db = new Entities();

        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
            

        }
        public ActionResult SortASC()
        {

            return View("Index", db.Posts.OrderBy(x => x.TimeStamp));

        }
        public ActionResult SortDESC()
        {

            return View("Index", db.Posts.OrderByDescending(x => x.TimeStamp));

        }






    }
}
