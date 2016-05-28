namespace MY.PIM.Services
{
    using AutoMapper;
    using MY.PIM.BUSINESSMANAGER;
    using MY.PIM.Services.Common;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel.Activation;

    [AutomapServiceBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Required)]
    public class BankService :BaseService,IBankService
    {
        
        public List<DataContracts.BankMaster> GetBankDetails(string bankName)
        {
            try
            {
                List<DataContracts.BankMaster> lstBankMaster = new List<DataContracts.BankMaster>();
                var bank= new DataContracts.BankMaster { 
                                        BankName ="ICICI",
                                        BankId=1,
                                        BankAccountNum ="Account",
                                        BankAddress1="Address 1",
                                        BankAddress2 ="Address 2",
                                        BankAccountType ="Checkings",
                                        BranchName ="EC",
                                        City="BNG",
                                        Country="India",
                                        IFSCCode="111",
                                        PhoneNumber="1111",
                                        RoutingNumber="111",
                                        StateCode="111",
                                        ZipCode="111"
                                        };
                lstBankMaster.Add(bank);
                return lstBankMaster;
                //var bankDetails= InvestmentManagerBC.GetBankDetails(bankName);
                //Mapper.CreateMap<ENTITYMODEL.usp_pam_GetBankDetails_Result, DataContracts.BankMaster>();
                //Mapper.CreateMap<DataContracts.BankMaster, ENTITYMODEL.usp_pam_GetBankDetails_Result>();
                //return Mapper.Map<List<ENTITYMODEL.usp_pam_GetBankDetails_Result>, List<DataContracts.BankMaster>>(bankDetails);
            }
            catch (Exception ex)
            {
                throw GetServiceFault(101,ex); 
            }
        }

        public string GetMessage()
        {
            return "hello from service";
        }
    }
}