using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarket
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            dgvSatislar.DataSource = dt;
            int TAdet = 0;
            double TTutar = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TAdet += Convert.ToInt32(dr["Adet"]);
                TTutar += Convert.ToDouble(dr["Tutar"]);
            }
            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();
        }
    }
}
