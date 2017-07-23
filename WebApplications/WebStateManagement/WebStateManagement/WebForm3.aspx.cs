using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateManagement
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.Browser.Cookies) //Cookies tarayıcıda engellenmediyse
                {
                    Response.Write("Seçilen marka : " + Request.Cookies["marka"].Value);

                    Response.Write("Kullanıcı : " + Request.Cookies["user"].Value);

                    Response.Write("Satış Departmanı : kullanıcı-1-" + Request.Cookies["Satis"]["user1"] + ", kullanıcı-2-" + Request.Cookies["Satis"]["user2"] + ", kullanıcı-3-" + Request.Cookies["Satis"]["user3"]);

                }
            }
        }
    }
}