using System;
using System.Collections.Generic;

namespace Claim.Models
{
    public partial class Claims
    {
        public Guid ClaimId { get; set; }
        public string ClaimNo { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string BranchCode { get; set; }
        public DateTime DateApply { get; set; }
        public string BankCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountHolderName { get; set; }
        public string Status { get; set; }
    }
}
