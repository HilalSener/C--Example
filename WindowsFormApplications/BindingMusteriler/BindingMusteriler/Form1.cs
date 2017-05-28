using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingMusteriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingSource bs1 = new BindingSource();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBagla();
            Konum();
        }

        private void Konum()
        {
            lblKonum.Text = (bs1.Position + 1) + " / " + (bs1.Count);
        }

        private void DataBagla()
        {

        }
    }
}
