using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateManagement
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(ViewState["durum"].ToString());
            if (!IsPostBack)
            {
                string durum = Request.QueryString["durum"];
                string kullanici = Request.QueryString["user"];

                Response.Write(kullanici + " durumu: " + durum);
            }
        }
    }
}