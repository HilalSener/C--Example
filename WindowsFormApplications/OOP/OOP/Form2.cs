using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            cTelefon tel = new cTelefon();
            MessageBox.Show(tel.AramaYap(txtTelefon.Text));
        }
    }
}
