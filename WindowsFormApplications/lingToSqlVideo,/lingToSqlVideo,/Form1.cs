using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lingToSqlVideo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VideoDataContext dc = new VideoDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmTurleriGetir();
        }

        private void FilmTurleriGetir()
        {

        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriGetirByFilmTuru(cbFilmTurleri.SelectedItem.ToString());
        }

        private void FilmleriGetirByFilmTuru(string FilmTuru)
        {

        }
    }
}
