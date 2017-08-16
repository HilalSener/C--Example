using eTicaret.BLL.Models;
using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eTicaret.Web.Presentation
{
    public partial class SatinAl : System.Web.UI.Page
    {
        KullaniciService ks = new KullaniciService();
        SatisService ss = new SatisService();
        SatisDetayService sds = new SatisDetayService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtEmail.Focus();
        }
        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var user = ks.KullaniciKontrol(txtEmail.Text, txtSifre.Text);
            if(user == null)
            {
                lblMesaj.Text = "Hatalı kullanıcı yada şifre girişi!";
                txtEmail.Focus();
            }
            else
            {
                lblMesaj.Text = "";
                Session["kullanici"] = user.id;
                pnlGiris.Visible = false;
                pnlAdres.Visible = true;
                txtAdi.Text = user.ad;
                txtSoyadi.Text = user.soyad;
                txtTelefon.Text = user.telefon;
                txtTc.Text = user.tckno;
                txtTeslimAdres.Text = user.adres;
                txtIlce.Text = user.ilce;
                txtIl.Text = user.il;
                txtTelefon.Focus();
            }
        }

        protected void btnAdresOnay_Click(object sender, EventArgs e)
        {
            //Kullanıcı bilgileri güncellenecek
            Kullanici k = new Kullanici();
            k.id = Convert.ToInt32(Session["kullanici"]);
            k.ad = txtAdi.Text;
            k.soyad = txtSoyadi.Text;
            k.tckno = txtTc.Text;
            k.telefon = txtTelefon.Text;
            k.adres = txtTeslimAdres.Text;
            k.ilce = txtIlce.Text;
            k.il = txtIl.Text;
            if (ks.AdresGuncelle(k))
            {
                lblAdresMesaj.Text = "Teslimat bilgileriniz güncellenmiştir.";
                //Satış kaydı oluşturulup, toplam satış adedi ve tutar bilgileri kayıt edilecek
                Satis s = new Satis();
                s.tarih = DateTime.Now;
                //DataTable dt = (DataTable)Session["sepet"];
                s.miktar = Convert.ToInt32(Session["toplamadet"]);    //spt.ToplamAdetBul(dt);
                s.tutar = Convert.ToDecimal(Session["toplamtutar"]);  //spt.ToplamTutarBul(dt);
                s.Kullanici.id = Convert.ToInt32(Session["kullanici"]); // ????
                s.teslimtarihi = DateTime.Now.AddDays(3);
                s.durumu = (Byte)Models.cEnums.SatisDurumu.siparis;
                if (ss.SatisEkle(s))
                {
                    DataTable dt = new DataTable();
                    int SonSatisNo = ss.SonSatisNoBul(s.Kullanici.id);
                    if (sds.SatisDetaylariEkleBySepet(dt, SonSatisNo))
                        lblAdresMesaj.Text = "Sipariş bilgileri sisteme aktarılmıştır.";
                    else
                        lblAdresMesaj.Text = "Siparişler aktarılamadı, yeniden deneyiniz!";
                }
                //Session.Remove("sepet");
                //Response.Redirect("Odeme.aspx");
            }

            //Satışa ait satış detayları yani (sepet) veritabanına aktarılacak

            //Sepet(Session["sepet"]) hafızadan silinecek

            //Ödeme sayfasına geçilecek
        }
    }
}