﻿using System;
using Microsoft.AspNetCore.Mvc;
using Resunet.BL.Auth;
using Resunet.ViewMapper;
using Resunet.ViewModels;

namespace Resunet.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IAuthBL authBl;

        public RegisterController(IAuthBL authBl)
        {
            this.authBl = authBl;
        }

        [HttpGet]
        [Route("/register")]
        public IActionResult Index()
        {
            return View("Index", new RegisterViewModel());
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult IndexSave(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                authBl.CreateUser(AuthMapper.MapRegisterViewModelToUserModel(model));
                return Redirect("/");
            }
            return View("Index", model);
        }
    }
}
