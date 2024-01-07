﻿using Microsoft.AspNetCore.Mvc;
using Resunet.BL.Auth;
using Resunet.ViewMapper;
using Resunet.ViewModels;

namespace Resunet.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthBL authBl;
        public LoginController(IAuthBL authBl)
        {
            this.authBl = authBl;
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult Index()
        {
            return View("Index", new LoginViewModel());
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult IndexSave(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                authBl.Authenticate(model.Email!, model.Password!, model.RememberMe == true);
                return Redirect("/");
            }
            return View("Index", model);
        }
    }
}