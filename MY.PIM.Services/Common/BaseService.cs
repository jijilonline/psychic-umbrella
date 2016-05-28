using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Web;
using MY.PIM.Services.Common.DataContracts;
using System.Net;

namespace MY.PIM.Services.Common
{
    public class BaseService
    {
        protected WebFaultException<ErrorData> GetServiceFault(int code, Exception ex)
        {
            string errorDesc = GetErrorDescription(101);
            string logMessage = string.Format("{0} : {1}", code, errorDesc);
           
            var errorData = new ErrorData(code, errorDesc, ex.Message + ' ' + ex.StackTrace);
            return new WebFaultException<ErrorData>(errorData, HttpStatusCode.InternalServerError);
        }

        private readonly List<KeyValuePair<int, string>> Description = new List<KeyValuePair<int, string>>
        {
            new KeyValuePair<int,string>(101,"PIM Service Error"),
            new KeyValuePair<int,string>(102,"DB Service Error")
        };

        private string GetErrorDescription(int code)
        {
            var desc = Description.Find(a=>a.Key==code);
            return desc.Equals(default(KeyValuePair<int,string>)) ? "Unspecified Error": desc.Value;
        }

    }
}