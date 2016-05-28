using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EM= MY.PIM.ENTITYMODEL;
using DC = MY.PIM.Services.DataContracts;
using AutoMapper;

namespace MY.PIM.Services.Common
{
    public static class AutoMapBootStrap
    {
        public static void InitializeMap()
        {
            Mapper.CreateMap<EM.usp_pam_GetBankDetails_Result,DC.BankMaster>();
        }
    }
}