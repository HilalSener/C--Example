using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRepeater
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=WISSEN-PC; Initial Catalog=Stock; uid=sa; pwd=1234");
                SqlCommand comm = new SqlCommand("select * from Categories", conn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                repCategories.DataSource = dr;
                repCategories.DataBind();

            }
        }
    }
}