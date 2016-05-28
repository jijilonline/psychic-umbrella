namespace MY.PIM.UIP
{
    using RestSharp;
    public class InvestmentServiceAgent : BaseServiceAgent, ISingleton
    {
        private RestClient GetServiceClient(string userCreds)
        {
            return GetServiceClient(MyPIMConstants.InvestmentService, userCreds);
        }

    }
       
}
