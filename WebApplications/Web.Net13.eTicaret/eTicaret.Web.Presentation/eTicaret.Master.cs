using eTicaret.BLL.Models;
using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eTicaret.Web.Presentation
{
    public partial class eTicaret : System.Web.UI.MasterPage
    {
        KategoriService ks = new KategoriService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var listeKategoriler = ks.GetAllKategoriler();
                foreach (Kategori kategori in listeKategoriler)
                {
                    MenuItem mitm = new MenuItem();
                    mitm.Text = kategori.kategoriad;
                    mitm.Value = kategori.id.ToString();
                    mnuKategoriler.Items.Add(mitm);
                    foreach (AltKategori altk in kategori.AltKategoriler)
                    {
                        MenuItem citm = new MenuItem();
                        citm.Text = altk.altkategoriad;
                        citm.Value = altk.id.ToString();
                        mitm.ChildItems.Add(citm);
                    }
                }
            }
        }

        protected void mnuKategoriler_MenuItemClick(object sender, MenuEventArgs e)
        {
            //e.Item.Text, e.Item.Value -> seçilen elemanın text ve value değerlerini veriyor.
            //e.Item.ValuePath --> Kategori_id / AltKategori_id veriyor.
            string[] Degerler = e.Item.ValuePath.Split('/');
            string altkno = "0";
            if (Degerler.Length > 1)
                altkno = Degerler[1];
            Response.Redirect("Default.aspx?kno=" + Degerler[0] + "&akno=" + altkno);
        }
    }
}