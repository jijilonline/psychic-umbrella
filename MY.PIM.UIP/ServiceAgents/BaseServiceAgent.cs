namespace MY.PIM.UIP
{
    using RestSharp;
    using RestSharp.Authenticators;
    using System.Configuration;

    public class BaseServiceAgent
    {
        public RestClient GetServiceClient(string serviceName, string userCreds)
        {
            var client= new RestClient(ConfigurationManager.AppSettings[serviceName])
            {
                Authenticator = new HttpBasicAuthenticator(userCreds,  ConfigurationManager.AppSettings["AppKey"])
            };
            client.AddHandler("application/json", new JsonNetDeserializer());
            return client;
        }
    }
}
