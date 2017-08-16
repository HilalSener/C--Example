using eTicaret.BLL.Models;
using eTicaret.Web.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eTicaret.Web.Presentation
{
    public partial class UrunDetay : System.Web.UI.Page
    {
        cSepet spt = new cSepet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int UrunID = Convert.ToInt32(Request.QueryString["id"]);
                UrunService us = new UrunService();
                dlstUrunler.DataSource = us.GetUrunByID(UrunID);
                dlstUrunler.DataBind();
            }
        }
        protected void dlstUrunler_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "sepet")
            {
                if (Session["sepet"] == null)
                {
                    Session["sepet"] = spt.YeniSepet();
                }
                DataTable dt = (DataTable)Session["sepet"];
                //Seçilen ürünün tüm özelliklerini elde et.
                int UrunID = Convert.ToInt32(e.CommandArgument);
                Label UrunAdi = (Label)e.Item.FindControl("lblUrunAd");
                TextBox Adet = (TextBox)e.Item.FindControl("txtAdet");
                Label Fiyat = (Label)e.Item.FindControl("lblFiyat");
                string[] Degerler = Fiyat.Text.Split(' '); //Para sembolünü ayırdık.
                //Fiyat.Text = Degerler[0];
                //Seçilen ürün zaten sepette var mı?
                bool Varmi = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["urunid"]) == UrunID)
                    {
                        dr["adet"] = Convert.ToInt32(dr["adet"]) + Convert.ToInt32(Adet.Text);
                        dr["tutar"] = Convert.ToDecimal(dr["tutar"]) + Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Degerler[0]);
                        Varmi = true;
                    }
                }
                if (Varmi == false)
                {
                    //DataTable'a (sepet) yeni bir satır ilave et.
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["urunid"] = UrunID;
                    dr["urunad"] = UrunAdi.Text;
                    dr["adet"] = Adet.Text;
                    dr["fiyat"] = Degerler[0];
                    dr["tutar"] = Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Degerler[0]);
                    dt.Rows.Add(dr);
                }
                Session["sepet"] = dt; //Sepetin son hali session a atılır.
                Session["toplamadet"] = spt.ToplamAdetBul(dt);
                Session["toplamtutar"] = spt.ToplamTutarBul(dt);
            }
        }
    }
}