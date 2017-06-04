using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqToSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext dc = new DataClasses1DataContext();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var Sonuc = from o in dc.Musterilers
                        where o.Silindi == false
                        select o;
                        //select new { o.ad, o.soyad, o.telefon, o.Kurslar.kursadi};
            dgvMusteriler.DataSource = Sonuc;
        }
    }
}
