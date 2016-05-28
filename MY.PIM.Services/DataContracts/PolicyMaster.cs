using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MY.PIM.Services.DataContracts
{
    [DataContract]
    [Serializable]
    public class PolicyMaster
    {
        [DataMember]
        public int PolicyId { get; set; }
        
        [DataMember]
        public string PolicyName { get; set; }
        
        [DataMember]
        public string PolicyType { get; set; }

        [DataMember]
        public string PolicyNumber { get; set; }

        [DataMember]
        public System.DateTime PolicyStartDt { get; set; }

        [DataMember]
        public System.DateTime PolicyMaturityDt { get; set; }

        [DataMember]
        public Nullable<decimal> PolicyPremiumAmt { get; set; }

        [DataMember]
        public string PolicyStatus { get; set; }

        [DataMember]
        public string PolicyPaymentTerm { get; set; }

        [DataMember]
        public string PolicyMaturity { get; set; }

        [DataMember]
        public Nullable<decimal> PolicySumAssured { get; set; }

        [DataMember]
        public string PolicyPaymentFrequency { get; set; }

        [DataMember]
        public string PolicyUserId { get; set; }

        [DataMember]
        public string PolicyPassword { get; set; }

        [DataMember]
        public string PolicyMobile { get; set; }

        [DataMember]
        public string PolicyWebsite { get; set; }

    }
}
