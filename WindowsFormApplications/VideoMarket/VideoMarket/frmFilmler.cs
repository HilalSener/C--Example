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
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();
        }

        private void frmFilmler_Load(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGoster(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(cbFilmTuru);
        }

        private void cbFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cFilmTuru ft = cbFilmTuru.SelectedItem as cFilmTuru;  //Dönüştüremezse hata vermez. Bunun gibi bir nesne oluşturur ya da oluşturamazsa yeni bir nesne oluşturur.
            cFilmTuru ft = (cFilmTuru)cbFilmTuru.SelectedItem;
            txtFilmTuru.Text = ft.TurAd;
            txtTurNo.Text = ft.FilmTurNo.ToString();
            //txtFilmTuru.Text = cbFilmTuru.SelectedItem.ToString();
            //cFilmTuru ft = new cFilmTuru();
            //txtTurNo.Text = Convert.ToString(ft.FilmTurNoGetirByTurAdi(txtFilmTuru.Text));
        }
    }
}
