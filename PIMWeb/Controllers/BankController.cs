using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MY.PIM.BE;
using MY.PIM.UIP;

namespace PIMWeb.Controllers
{
    public class BankController : Controller
    {
        //
        // GET: /Investments/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetBankDetails()
        {
            List<BankMaster> listBank = new BankUIP().GetBankDetails("ICICI", string.Empty);
            return new JsonResult { Data = listBank, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
	}
}