using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MTC28NR; Initial Catalog=VideoMarket; uid=sa; pwd=1234;");

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select FilmNo, FilmAd, TurAd, Yonetmen, Oyuncular, Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo", conn);
            try
            {
                //da.Fill(ds, "Filmler");
                da.Fill(dt);
                //dgvFilmler.DataSource = ds.Tables["Filmler"];
                dgvFilmler.DataSource = dt;
                dgvFilmler.Columns[0].Visible = false;
                dgvFilmler.Columns["Oyuncular"].Width = 200;
                dgvFilmler.Columns["Miktar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                txtSayisi.Text = dgvFilmler.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }
    }
}
