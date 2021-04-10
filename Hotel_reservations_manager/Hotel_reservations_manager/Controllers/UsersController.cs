using Hotel_reservations_manager.Helpers;
using Hotel_reservations_manager.Models;
using Hotel_reservations_manager.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Controllers
{
    public class UsersController : Controller
    {
        private bool IsUserAuthenticated()
        {
            IAuthenticationHelper authHelper = new SessionAuthenticationHelper(HttpContext.Session);
            return authHelper.IsUserAuthenticated();
        }

        [HttpGet]
        public IActionResult Register()
        {
            if(IsUserAuthenticated())
                return Redirect("/");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel model)
        {
            if (IsUserAuthenticated())
                return Redirect("/");

            if (ModelState.IsValid)
            {
                model.RegisterUser();
                return RedirectToAction("Login");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (IsUserAuthenticated())
                return Redirect("/");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (IsUserAuthenticated())
                return Redirect("/");

            if (ModelState.IsValid)
            {
                var user = model.AuthenticateUser();
                if (user != null)
                {
                    //auth ok, save to session
                    IAuthenticationHelper authHelper = new SessionAuthenticationHelper(HttpContext.Session);
                    authHelper.SaveState(user);
                    return Redirect("/");
                }
                else
                {
                    //add error
                    ModelState.AddModelError(string.Empty, "The username or password provided is incorrect.");
                }
            }
            return View(model);
        }


    }
}
