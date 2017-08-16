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
    public partial class Sepet : System.Web.UI.Page
    {
        cSepet spt = new cSepet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["sepet"] == null)
                {
                    Session["sepet"] = spt.YeniSepet();
                }
                DataTable dt = (DataTable)Session["sepet"];
                SepetGoster(dt);
            }
        }
        private void SepetGoster(DataTable dt)
        {
            repSepet.DataSource = dt;
            repSepet.DataBind();
            Session["toplamadet"] = spt.ToplamAdetBul(dt);
            Session["toplamtutar"] = spt.ToplamTutarBul(dt);
        }
        protected void repSepet_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "sil")
            {
                DataTable dt = (DataTable)Session["sepet"];
                dt.Rows.RemoveAt(e.Item.ItemIndex);
                Session["sepet"] = dt;
                SepetGoster(dt);
            }
        }
    }
}