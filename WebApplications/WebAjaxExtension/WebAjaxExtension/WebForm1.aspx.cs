using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAjaxExtension
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString();
        }

        protected void btnGoster_Click(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString();
            lblAjaxZaman.Text = DateTime.Now.ToString();
        }
    }
}