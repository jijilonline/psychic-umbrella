using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.PIM.BE
{
    [Serializable]
    public class BankMaster
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string BankAccountType { get; set; }
        public string BankAccountNum { get; set; }
        public string RoutingNumber { get; set; }
        public string IFSCCode { get; set; }
        public string BranchName { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
