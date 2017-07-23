using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["durum"] = "Aktif"; //ömrü sadece tanımlandığı sayfayla kısıtlı.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write(ViewState["durum"].ToString());
            //Response.Redirect("WebForm2.aspx");
            //Response.Redirect("WebForm2.aspx?durum=Aktif&user=Admin");
            Response.Redirect("WebForm2.aspx?durum=Aktif&user=" + TextBox1.Text);
        }
    }
}