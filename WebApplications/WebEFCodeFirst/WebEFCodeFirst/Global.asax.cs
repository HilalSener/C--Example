using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WebEFCodeFirst.DataModel;

namespace WebEFCodeFirst
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            using (StokDataContext ent = new StokDataContext())
            {
                ent.Database.CreateIfNotExists();
            }
        }
    }
}