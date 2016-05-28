using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.PIM.BE
{
    public class PolicyMaster
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyType { get; set; }
        public string PolicyNumber { get; set; }
        public System.DateTime PolicyStartDt { get; set; }
        public System.DateTime PolicyMaturityDt { get; set; }
        public Nullable<decimal> PolicyPremiumAmt { get; set; }
        public string PolicyStatus { get; set; }
        public string PolicyPaymentTerm { get; set; }
        public string PolicyMaturity { get; set; }
        public Nullable<decimal> PolicySumAssured { get; set; }
        public string PolicyPaymentFrequency { get; set; }
        public string PolicyUserId { get; set; }
        public string PolicyPassword { get; set; }
        public string PolicyMobile { get; set; }
        public string PolicyWebsite { get; set; }

    }
}
