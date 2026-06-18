using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public class BloodUnit
    {
        public string UnitId { get; set; }
        public string BloodGroup { get; set; }
        public DateTime CollectedOn { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string DonorId { get; set; }
        public string Status { get; set; } = "Available";
        public int Quantity { get; set; } = 1;
    }
}
