using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.AppServices.Claim.Dto
{
    public class ClaimDetailsDto
    {
        public Guid ClaimDetailsId { get; set; }
        public string ClaimNo { get; set; }
        public string SerialNo { get; set; }
        public string CostCentreCode { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public string GLCode { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public decimal GST { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
