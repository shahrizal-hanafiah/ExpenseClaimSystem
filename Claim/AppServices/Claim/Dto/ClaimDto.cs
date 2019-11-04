using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.AppServices.Claim.Dto
{
    public class ClaimDto
    {
        public Guid ClaimId { get; set; }
        public string ClaimNo { get; set; }
        public string Name { get; set; }
        public string BranchCode { get; set; }
        public DateTime DateApply { get; set; }
        public string BankCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountHolderName { get; set; }
        public string Status { get; set; }
    }
}
