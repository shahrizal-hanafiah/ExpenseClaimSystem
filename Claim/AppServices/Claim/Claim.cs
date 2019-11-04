using Claim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.AppServices.Claim
{
    public class Claim
    {
        public bool CreateClaim()
        {
            var result = false;
            try
            {
                using (var db = new ClaimContext())
                {
                    var newClaim = new Claims()
                    {

                    };
                    db.Claims.Add(newClaim);
                    db.SaveChanges();
                }
                result = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool UpdateClaim()
        {
            var result = false;
            try
            {
                using (var db = new ClaimContext())
                {
                    var newClaim = new Claims()
                    {

                    };
                    db.Claims.Add(newClaim);
                    db.SaveChanges();
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
