using System;
using System.Collections.Generic;

namespace Claim.Models
{
    public partial class CostCentre
    {
        public int Id { get; set; }
        public string CostCentreCode { get; set; }
        public string CostCentreName { get; set; }
        public string CostCentreDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
