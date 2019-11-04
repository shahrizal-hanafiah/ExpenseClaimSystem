using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Claim.AppServices;
using Claim.Models;
using Microsoft.AspNetCore.Mvc;

namespace Claim.Controllers
{
    public class LoginController : Controller
    {
        private LoginAppService _login = new LoginAppService();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            _login.LoginProcess(login);
            return RedirectToAction("Index", "Home");
            //return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}