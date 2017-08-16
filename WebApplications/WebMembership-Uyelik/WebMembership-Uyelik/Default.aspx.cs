using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMembership_Uyelik
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Label1.Text = "Hoşgeldin, " + Session["user"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}