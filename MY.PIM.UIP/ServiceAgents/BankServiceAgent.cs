namespace MY.PIM.UIP
{
    using MY.PIM.BE;
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Net;

    public class BankServiceAgent:BaseServiceAgent,ISingleton
    {
        
        private RestClient GetServiceClient(string userCreds)
        {
            return GetServiceClient(MyPIMConstants.BankService, userCreds);
        }
        public string GetMessage(string userCreds)
        {
            try
            {
                var client = GetServiceClient(userCreds);
                var request = new RestRequest(MyPIMConstants.GetMessage)
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    JsonSerializer = new JsonNetSerializer(),

                };
                request.AddHeader("Accept", "application/json");
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<string>(response.Content);
                }
                var errorData = JsonConvert.DeserializeObject<ErrorData>(response.Content);
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<BankMaster> GetBankDetails(string bankName, string userCreds)
        {
            try
            {
                var client = GetServiceClient(userCreds);
                var request = new RestRequest(MyPIMConstants.GetBankDetailsURL)
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    JsonSerializer = new JsonNetSerializer(),
                    
                };
                //request.AddParameter("bankname", bankName, ParameterType.UrlSegment);
                //request.AddParameter("Accept", "application/json",ParameterType.HttpHeader);
                request.AddUrlSegment("bankname", bankName);
                request.AddHeader("Accept", "application/json");
                var response = client.Execute(request);
                //var response = client.Execute<List<BankMaster>>(request);
                if(response.StatusCode==HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<List<BankMaster>>(response.Content);
                }
                var errorData = JsonConvert.DeserializeObject<ErrorData>(response.Content);
                throw new Exception();
                //throw new MYException(response.StatusDescription, response.ErrorException,errorData);
            }
            catch (Exception ex)
            {
                throw ex;   
            }
        }

    }

   
}
