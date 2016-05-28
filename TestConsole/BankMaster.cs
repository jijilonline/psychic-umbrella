using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MY.PIM.Services.DataContracts
{
    [DataContract]
    [Serializable]
    public class BankMaster
    {
        [DataMember]
        public int BankId { get; set; }

        [DataMember]
        public string BankName { get; set; }

        [DataMember]
        public string BankAccountType { get; set; }

        [DataMember]
        public string BankAccountNum { get; set; }
        
        [DataMember]
        public string RoutingNumber { get; set; }

        [DataMember]
        public string IFSCCode { get; set; }

        [DataMember]
        public string BranchName { get; set; }

        [DataMember]
        public string BankAddress1 { get; set; }

        [DataMember]
        public string BankAddress2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string StateCode { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
