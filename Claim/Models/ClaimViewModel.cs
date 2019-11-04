using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.Models
{
    public class ClaimViewModel
    {
        public string ClaimNo { get; set; }
        public string Name { get; set; }
        public string BranchCode { get; set; }
        public string BankCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountHolderName { get; set; }
        public string Status { get; set; }
    }
}
