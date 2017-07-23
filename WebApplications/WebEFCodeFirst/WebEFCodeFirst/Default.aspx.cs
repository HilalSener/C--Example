using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebEFCodeFirst.DataModel;

namespace WebEFCodeFirst
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StokDataContext ent = new StokDataContext();
                //Repeater1.DataSource = ent.Kategoriler.ToList();
                //Repeater1.DataBind();

                //Kategori k1 = new Kategori() { KategoriAdi = "Yazılım" };
                //Kategori k2 = new Kategori() { KategoriAdi = "Sistem" };
                //Kategori k3 = new Kategori() { KategoriAdi = "Mobile" };

                //ent.Kategoriler.Add(k1);
                //ent.Kategoriler.Add(k2);
                //ent.Kategoriler.Add(k3);

                //ent.SaveChanges();

                //Response.Write("CodeFirst yöntemiyle Database oluşturma işlemleri tamamlandı.");

                var KategoriListesi = ent.Kategoriler.ToList();
                //LazyLoadingEnable = false olmasına rağmen alt kategorileri yine de Kategorilerle birlikte çekmek istersek;
                //var KategoriListesi = ent.Kategoriler.Include("AltKategoriler").ToList();
                foreach (Kategori k in KategoriListesi)
                {
                    MenuItem mitm = new MenuItem();
                    mitm.Text = k.KategoriAdi;
                    mitm.Value = k.ID.ToString();
                    mnuKategoriler.Items.Add(mitm);

                    var AltKategoriListesi = ent.AltKategoriler.Where(ak => ak.Kategori.ID == k.ID).ToList();
                    //var AltKategoriListesi = (from ak in ent.AltKategoriler
                                             //where ak.Kategori.ID == k.ID
                                             //select ak).ToList();
                    //Lazy Loading nedeniyle tüm ilişkili verilerde koleksiyonlara yükleniyor. 
                    //foreach (AltKategori ak in k.AltKategoriler)
                    //foreach (AltKategori ak in AltKategoriListesi)
                    //eğer LazyLoadingEnable = false ise; ayrıca AltKategorileri de çekmemiz lazım
                    foreach(AltKategori ak in AltKategoriListesi)
                    {
                        MenuItem citm = new MenuItem();
                        citm.Text = ak.AltKategoriAdi;
                        citm.Value = ak.ID.ToString();
                        mitm.ChildItems.Add(citm);
                    }
                }
            }
        }
    }
}