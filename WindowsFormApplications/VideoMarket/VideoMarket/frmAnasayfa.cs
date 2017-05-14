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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitmFilmTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmler frm = new frmFilmler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mitmFilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmTurleri frm = new frmFilmTurleri();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void musterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
