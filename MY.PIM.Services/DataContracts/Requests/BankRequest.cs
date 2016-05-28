using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MY.PIM.Services.DataContracts
{
    [DataContract]
    public class BankRequest
    {
        [DataMember]
        public int BankId { get; set; }

        [DataMember]
        public string BankName { get; set; }

        [DataMember]
        public string BankAccountType { get; set; }

        [DataMember]
        public string BankAccountNum { get; set; }
        
        
    }
}
