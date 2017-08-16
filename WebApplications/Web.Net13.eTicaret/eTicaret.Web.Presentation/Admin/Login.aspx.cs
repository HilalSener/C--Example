using eTicaret.BLL.Models;
using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eTicaret.Web.Presentation.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        KullaniciService ks = new KullaniciService(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtEmail.Focus();
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici admin = ks.KullaniciKontrolByAdmin(txtEmail.Text, txtSifre.Text);
            if (admin != null)
            {
                Session["Admin"] = admin.id;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMesaj.Text = "Kullanıcı bilgileriniz hatalı ya da Admin yetkiniz yok!";
                txtEmail.Focus();
            }
        }
    }
}