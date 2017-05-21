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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MTC28NR; Initial Catalog=VideoMarket; uid=sa; pwd=1234;");

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int TAdet = 0;
            double TTutar = 0;
            SqlDataAdapter da = new SqlDataAdapter("select SatisNo, FilmAd, MusteriAd + ' ' + MusteriSoyad as Musteri, Adet, BirimFiyat, Adet * BirimFiyat as Tutar from FilmSatis fs inner join Filmler f on fs.FilmNo = f.FilmNo inner join Musteriler m on fs.MusteriNo = m.MusteriNo where fs.Silindi = 0", conn);
            try
            {
                da.Fill(dt);
                dgvSatislar.DataSource = dt;
                dgvSatislar.Columns[0].Visible = false;
                dgvSatislar.Columns["FilmAd"].Width = 180;
                dgvSatislar.Columns["Adet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSatislar.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //for (int i = 0; i < dgvSatislar.Rows.Count; i++)
                //{
                //    TAdet += Convert.ToInt32(dgvSatislar.Rows[i].Cells["Adet"].Value);
                //    TTutar += Convert.ToDouble(dgvSatislar.Rows[i].Cells["Tutar"].Value);
                //}
                foreach (DataRow dr in dt.Rows)
                {
                    TAdet += Convert.ToInt32(dr["Adet"]);
                    TTutar += Convert.ToDouble(dr["Tutar"]);
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();
        }
    }
}
