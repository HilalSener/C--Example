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
    public partial class frmFilmSorgulama : Form
    {
        public frmFilmSorgulama()
        {
            InitializeComponent();
        }

        private void frmFilmSorgulama_Load(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGoster(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(cbFilmTuru);
            cbFilmTuru.Items.Insert(0, "Tüm Türler");

        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            FilmSorgula();
        }
        private void txtYonetmeneGore_TextChanged(object sender, EventArgs e)
        {
            FilmSorgula();
        }

        private void txtOyuncularaGore_TextChanged(object sender, EventArgs e)
        {
            FilmSorgula();
        }

        private void cbFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSorgula();
        }

        private void FilmSorgula()
        {
            string TureGore = "";
            if (cbFilmTuru.SelectedItem.ToString() != "Tüm Türler")
                TureGore = cbFilmTuru.SelectedItem.ToString();
            cFilm f = new cFilm();
            f.FilmleriGosterBySorgulama(lvFilmler, txtAdaGore.Text, TureGore, txtYonetmeneGore.Text, txtOyuncularaGore.Text);
        }
    }
}
