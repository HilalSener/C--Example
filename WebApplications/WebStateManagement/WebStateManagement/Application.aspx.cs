using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateManagement
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application.Add("duyuru", "Kampnayamız stoklarla sınırlıdır.");
            //Application["Kampanya"] = "Kampanyamız ay sonuna kadar geçerlidir.";
            //Application.Remove("duyuru");
            //Application.RemoveAll();
            Response.Write("online ziyaretçi sayısı: " + Application["onlineziyaretci"].ToString());
        }
    }
}