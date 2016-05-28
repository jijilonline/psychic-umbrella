namespace MY.PIM.UIP
{
    using MY.PIM.BE;
    using System.Collections.Generic;

    public class BankUIP:ISingleton
    {
        public List<BankMaster> GetBankDetails(string bankName, string userCreds)
        {
                var bankServiceAgent = Singleton<BankServiceAgent>.Instance;
                string msg = GetMessage(SecurityManager.CurrentUser);
                return bankServiceAgent.GetBankDetails(bankName, SecurityManager.CurrentUser);
        }

        public string GetMessage(string userCreds)
        {
            var msgEvent = Singleton<BankServiceAgent>.Instance;
            return msgEvent.GetMessage(SecurityManager.CurrentUser);
        }
    }

}
