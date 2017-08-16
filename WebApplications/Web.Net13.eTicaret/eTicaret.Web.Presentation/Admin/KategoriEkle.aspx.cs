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
    public partial class KategoriEkle : System.Web.UI.Page
    {
        KategoriService ks = new KategoriService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (Session["Admin"] == null)
                    Response.Redirect("Login.aspx");
            else
                KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            gvKategoriler.DataSource = ks.GetAllKategoriler();
            gvKategoriler.DataBind();
        }

        protected void gvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlKategorier.Visible = true;
            txtAdi.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[1].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[2].Text);
            txtAdi.Focus();
        }

        protected void lbYeniKategori_Click(object sender, EventArgs e)
        {
            pnlKategorier.Visible = true;
            Temizle();
        }

        private void Temizle()
        {
            txtAdi.Text = "";
            txtAciklama.Text = "";
            txtAdi.Focus();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAdi.Text.Trim() != "")
            {
                Kategori k = new Kategori();
                k.kategoriad = txtAdi.Text;
                k.aciklama = txtAciklama.Text;
                if(ks.KategoriEkle(k))
                {
                    pnlKategorier.Visible = false;
                    KategorileriGetir();
                }
            }
        }
    }
}