using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MY.PIM.BE
{
    [Serializable]
    public class ErrorData
    {
        public ErrorData() { }
        public ErrorData(int code, string reason, string detailedInformation)
        {
            Code = code;
            Reason = reason;
            DetailedInformation = detailedInformation;
        }

        public int Code { get; private set; }
        public string Reason { get; private set; }
        public string DetailedInformation { get; private set; }


    }
}