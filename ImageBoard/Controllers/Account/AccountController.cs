using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageBoard.Helpers.Exceptions;
using System.Diagnostics;
using ImageBoard.Data.Service.Interfaces;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace ImageBoard.Controllers.Account
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService) {
            _accountService = accountService;
        }


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
            try
            {
                _accountService.RegisterUser(newUser);
                // TODO: redirected to homepage

            }
            catch (UserExistsException ex) {
                Trace.Write(ex.Message);
            }

            return View("Registration");
        }

        public ActionResult Login(RegisterModel user) {
            // check if user exists
            var checkUser = _accountService.Login(user);

            if (checkUser == null) {
                return View();
            }

            // rest
            JavaScriptSerializer jsData = new JavaScriptSerializer();
            UserCookie userCookie = new UserCookie(checkUser);
            string data = jsData.Serialize(userCookie);
            FormsAuthenticationTicket autho = new FormsAuthenticationTicket(1, checkUser.Id.ToString(), DateTime.Now, DateTime.Now.AddMonths(6), true, data);
            string encToken = FormsAuthentication.Encrypt(autho);
            HttpCookie authoCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encToken);
            Response.Cookies.Add(authoCookie);

            return RedirectToAction("Index", "Home");

        }

        [Authorize]
        public ActionResult Logout() {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public ActionResult TestLog() {
            return View("Test");
        }
    }
}