namespace MY.PIM.Services
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IBankService
    {
        [OperationContract]
        [WebInvoke(Method="GET",
                UriTemplate = "GetBankDetails/{bankname}",
                RequestFormat=WebMessageFormat.Json,
                ResponseFormat=WebMessageFormat.Json)]
        List<DataContracts.BankMaster> GetBankDetails(string bankName);


        [OperationContract]
        [WebInvoke(Method = "GET",
                UriTemplate = "GetMessage",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        string GetMessage();

    }


}
