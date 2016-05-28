using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using RestSharp.Serializers;

namespace MY.PIM.UIP
{
    public class JsonNetSerializer : ISerializer
    {
        public string ContentType
        {
            get;
            set;
        }

        public string DateFormat
        {
            get;
            set;
        }

        public string Namespace
        {
            get;
            set;
        }

        public string RootElement
        {
            get;
            set;
        }
        public JsonNetSerializer()
        {
            ContentType = "application/json";
        }
        public string Serialize(object obj)
        {
            if (null == obj) throw new ArgumentNullException("obj");
            var msDateformatStrings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            return JsonConvert.SerializeObject(obj,msDateformatStrings);
        }

    }
}
