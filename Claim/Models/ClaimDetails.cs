using System;
using System.Collections.Generic;

namespace Claim.Models
{
    public partial class ClaimDetails
    {
        public int Id { get; set; }
        public Guid ClaimId { get; set; }
        public string SerialNo { get; set; }
        public DateTime DateTransaction { get; set; }
        public string CostCentreCode { get; set; }
        public string Glcode { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
