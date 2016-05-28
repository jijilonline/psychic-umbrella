namespace MY.PIM.UIP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    public static class SecurityManager
    {
        public static string CurrentUser
        {
            get
            {
                var currentUser = "Jijil";// System.Web.HttpContext.Current.User.Identity.Name;
                if(string.IsNullOrEmpty(currentUser))
                {
                    throw new Exception("Invalid User");
                }
                return currentUser;
            }

        }

    }
}
