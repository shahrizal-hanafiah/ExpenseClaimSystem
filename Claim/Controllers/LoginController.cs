using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Claim.Models;
using Microsoft.AspNetCore.Mvc;

namespace Claim.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            return RedirectToAction("Index", "Home");
            //return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}