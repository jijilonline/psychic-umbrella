using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace MY.PIM.Services.Common.DataContracts
{
    [DataContract]
    [XmlSerializerFormat()]
    public class ErrorData
    {
        public ErrorData(int code, string reason, string detailedInformation)
        {
            Code = code;
            Reason = reason;
            DetailedInformation = detailedInformation;
        }

        [DataMember]
        public int Code { get; private set; }

        [DataMember]
        public string Reason { get; private set; }

        [DataMember]
        public string DetailedInformation { get; private set; }


    }
}