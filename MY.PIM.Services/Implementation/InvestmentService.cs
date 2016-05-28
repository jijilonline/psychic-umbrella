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
    public class InvestmentService :BaseService,IInvestmentService
    {
      
    }
}