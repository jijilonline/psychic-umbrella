using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY.PIM.ENTITYMODEL;
using System.Data.Entity;

namespace MY.PIM.BUSINESSMANAGER
{
    internal class InvestmentBC
    {
        public static List<ENTITYMODEL.usp_pam_GetBankDetails_Result> GetBankDetails(string bankName)
        { 
            using(var entityContext = new ENTITYMODEL.InvestmentEntities())
            {
               return  entityContext.usp_pam_GetBankDetails(bankName).ToList();
            }
         }
    }
}
