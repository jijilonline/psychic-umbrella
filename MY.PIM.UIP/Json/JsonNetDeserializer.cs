using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using RestSharp.Deserializers;

namespace MY.PIM.UIP
{
    public class JsonNetDeserializer :IDeserializer  
    {
        public T Deserialize<T>(IRestResponse response)
        {
            if (response == null) throw new ArgumentException("response");
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        public string DateFormat
        {
            get;
            set;
        }
        public string Namespace
        {
            get;set;
        }
        public string RootElement
        {
            get;
            set;
        }
    }
}
