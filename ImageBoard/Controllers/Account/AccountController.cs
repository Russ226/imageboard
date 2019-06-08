using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageBoard.Helpers.Exceptions;
using System.Diagnostics;
using ImageBoard.Data.Service.Interfaces;

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
    }
}