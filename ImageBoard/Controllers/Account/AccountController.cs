using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageBoard.Controllers.Account
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Register() {
            
            return View("Registration");
        }

        [ActionName("Register")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult RegisterPost(RegisterModel newUser)
        {

            return View("Registration");
        }
    }
}