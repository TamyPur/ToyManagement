using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Server.DAL;
using Server.Models;

namespace Server.Controllers
{
    public class UserController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

    }
}
