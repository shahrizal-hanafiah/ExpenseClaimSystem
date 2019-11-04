using System;
using System.Collections.Generic;

namespace Claim.Models
{
    public partial class Taxes
    {
        public int Id { get; set; }
        public string TaxName { get; set; }
        public string TaxCode { get; set; }
        public decimal TaxRate { get; set; }
        public bool IsActive { get; set; }
    }
}
