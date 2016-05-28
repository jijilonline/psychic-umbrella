using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY.PIM.BE;
using ENTITYMODEL= MY.PIM.ENTITYMODEL;
using DataContracts = MY.PIM.Services.DataContracts;
using MY.PIM.BUSINESSMANAGER;
using AutoMapper;
using TestConsole.BankService;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BankServiceClient client = new BankServiceClient();
            var x = client.GetMessage();

            List<DataContracts.BankMaster> lstBank = GetBankDetails("ICICI");
        }

        private static List<DataContracts.BankMaster> GetBankDetails(string bankName)
        {
            try
            {
                var bankDetails = InvestmentManagerBC.GetBankDetails(bankName);
                Mapper.CreateMap<ENTITYMODEL.usp_pam_GetBankDetails_Result, DataContracts.BankMaster>();
                return Mapper.Map<List<ENTITYMODEL.usp_pam_GetBankDetails_Result>, List<DataContracts.BankMaster>>(bankDetails);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
