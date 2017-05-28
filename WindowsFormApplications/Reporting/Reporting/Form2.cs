using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VideoMarketDataSet1.vw_DetayliFilmSatis' table. You can move, or remove it, as needed.
            this.vw_DetayliFilmSatisTableAdapter.Fill(this.VideoMarketDataSet1.vw_DetayliFilmSatis);

            this.reportViewer1.RefreshReport();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            this.vw_DetayliFilmSatisTableAdapter.FillByMusteri(this.VideoMarketDataSet1.vw_DetayliFilmSatis, txtMusteriyeGore.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
