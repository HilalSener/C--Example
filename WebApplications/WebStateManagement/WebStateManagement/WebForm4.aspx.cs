using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateManagement
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                    Response.Redirect("Session.aspx");
                else
                {
                    Response.Write("Hoşgeldin, " + Session["user"].ToString() + ", Session ID : " + Session.SessionID);
                    Response.Write("Yıllık Mali Bilanço");
                }
            }
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Remove("user"); //ismi belirtilen session iptal edilir.
            Session.RemoveAll(); //Tüm session lar iptal edilir.
        }
    }
}