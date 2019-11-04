using Claim.AppServices.Claim.Dto;
using Claim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.AppServices.Claim
{
    public class ClaimAppService
    {
        public Guid CreateClaim(ClaimViewModel claim)
        {
            try
            {
                using (var db = new ClaimContext())
                {
                    var claimCount = db.Claims.Where(t => t.DateApply.Date == DateTime.UtcNow.Date).Count() + 1;
                    var newClaim = new Claims()
                    {
                        ClaimId = Guid.NewGuid(),
                        Name = claim.Name,
                        ClaimNo = DateTime.Now.ToString("yyyyMMdd") + claimCount.ToString().PadLeft(5,'0'),
                        BankCode = claim.BankCode,
                        BankAccount = claim.BankAccount,
                        BranchCode = claim.BranchCode,
                        AccountHolderName = claim.AccountHolderName,
                        DateApply = DateTime.UtcNow,
                        Status = "NEW"
                    };
                    db.Claims.Add(newClaim);
                    db.SaveChanges();
                    return newClaim.ClaimId;
                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
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
