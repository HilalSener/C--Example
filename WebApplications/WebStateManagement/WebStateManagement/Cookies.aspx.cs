using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateManagement
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Cookies["marka"].Value = ddlMarkalar.SelectedItem.ToString();
            //Non-Persistent (Kalıcı Olmayan) Cookies, client (kullanıcı) bilgisayarında 4K bir dosya olarak oluşturulur ve oturum kapanıncaya kadar (default : 30 dk.) saklanır.
            Response.Cookies["marka"].Expires = DateTime.Now.AddDays(2); //Cookie, Persistent yani kalıcı hale gelir ve belirtilen son kullanma tarihine kadar kullanıcı bilgisayarında kayıtlı tutulur.

            HttpCookie user = new HttpCookie("user");
            user.Value = "Admin";
            user.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(user);

            Response.Cookies["Satis"]["user1"] = "Vedat";
            Response.Cookies["Satis"]["user2"] = "Neşe";
            Response.Cookies["Satis"]["user3"] = "Oya";
            Response.Cookies["Satis"].Expires = DateTime.Now.AddDays(1);

            Response.Redirect("WebForm3.aspx");
        }
    }
}