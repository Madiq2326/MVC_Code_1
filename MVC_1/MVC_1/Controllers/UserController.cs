using MVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext myContext = new ApplicationDbContext();
        // GET: User
        public ActionResult Index()
        {
            var list = myContext.users.ToList();
            return View(list);
        }
    }
}
