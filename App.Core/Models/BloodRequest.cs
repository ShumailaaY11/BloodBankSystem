using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public class BloodRequest
    {
        public string RequestId { get; set; }
        public string PatientName { get; set; }
        public string BloodGroup { get; set; }
        public int UnitsNeeded { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? RequiredBy { get; set; }
        public string Status { get; set; } = "Pending";
        public string Hospital { get; set; }
        public string Notes { get; set; }
    }
}
