using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPostback
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Merhaba ASP.Net");
            //if (IsPostBack)
            //    Response.Write("Sayfa postback oldu.");
            //else
            //    Response.Write("Sayfa ilk defa yüklendi.");
            if (!IsPostBack)
                Response.Write("Sayfa ilk defa yüklendi.");
            this.Title = "ASP.Net WebForms ile güçlü server side programlama";
            this.MetaDescription = "ASP.Net ile Visual Studio'nun OOP sınıflarından ve olaya dayalı programlama gücünden maksimum faydalanabiliriz.";
            this.MetaKeywords = "ASP.Net, WebForms, SEO, Search Engine Optimization, server side, OOP, event oriented, web programming";
            //Title, Description ve Keywords, sayfa ile ilgili ve birbiriyle uyumlu olarak düzenlenmeli. Mümkünse sayfadaki değişiklikler karşısında dinamik olarak yeniden düzenlenmelidir.
            //Sayfalarda bulunan tüm açıklamalar, bize özgün yani başka sitelerden kopyalanmamış olmalıdır.
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            //Response.Write("Butona tıklandı!");
            //Response.Write("Merhaba " + txtAdi.Text);
            lblMesaj.Text = "Merhaba " + txtAdi.Text;
        }
    }
}