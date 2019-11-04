using System;
using System.Collections.Generic;

namespace Claim.Models
{
    public partial class GeneralLedgers
    {
        public int Id { get; set; }
        public string Glcode { get; set; }
        public string Glname { get; set; }
        public string Gldescription { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
