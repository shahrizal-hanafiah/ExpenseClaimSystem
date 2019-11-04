using Claim.Helpers;
using Claim.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.AppServices
{
    public class LoginAppService
    {
        public LoginAppService()
        {
        }
        public bool LoginProcess(LoginViewModel login)
        {
            using (var db = new ClaimContext())
            {
                var user = db.Users.Where(t => t.Username.ToLower() == login.Username.ToLower() && t.Password == SHA.GenerateSHA512String(login.Password)).FirstOrDefault();
            }
            return true;
        }
    }
}
