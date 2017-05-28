using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoMarketDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.videoMarketDataSet.Musteriler);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs1.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bs1.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs1.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs1.MoveLast();
        }
    }
}
