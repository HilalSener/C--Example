using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAjaxExtension
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnGetir_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=WISSEN-PC; Initial Catalog=VideoMarket; uid=sa; pwd=1234");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Filmler where Varmi=1 and FilmNo < 6 ", conn);
            da.Fill(dt);
            gvFilmler.DataSource = dt;
            gvFilmler.DataBind();
        }
    }
}