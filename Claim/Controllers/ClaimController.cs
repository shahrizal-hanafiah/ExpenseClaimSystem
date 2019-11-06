using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Claim.AppServices.Claim;
using Claim.AppServices.Claim.Dto;
using Claim.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Claim.Controllers
{
    public class ClaimController : Controller
    {
        private ClaimAppService _claimAppService = new ClaimAppService();
        public ClaimController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessClaim([FromBody]ClaimViewModel data)
        {
            try
            {
                var result = _claimAppService.CreateClaim(data);
                //return RedirectToAction("ClaimDetail","Claim",new { claimNo = result});
                return Json(result);
            }
            catch (Exception)
            {
                return Json("Fail");
            }
            
        }

        public IActionResult ClaimDetail(Guid claimNo)
        {
            return View();
        }

        public IActionResult GetClaim()
        {
            return View();
        }
    }
}