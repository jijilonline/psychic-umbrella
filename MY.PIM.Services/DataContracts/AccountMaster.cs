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
    public class AccountMaster
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string AccountType { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }
    }
}
