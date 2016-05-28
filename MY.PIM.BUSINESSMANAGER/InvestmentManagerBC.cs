using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY.PIM.ENTITYMODEL;
using AutoMapper;
using MY.PIM.BE;

namespace MY.PIM.BUSINESSMANAGER
{
    public class InvestmentManagerBC
    {
        public static List<ENTITYMODEL.usp_pam_GetBankDetails_Result> GetBankDetails(string bankName)
        {
            return InvestmentBC.GetBankDetails(bankName);
        }

    }
}
