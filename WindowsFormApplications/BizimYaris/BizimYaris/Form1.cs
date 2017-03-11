using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimYaris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pb1.Left = 20;
            pb2.Left = 20;
            pb3.Left = 20;
            pb4.Left = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1.Left += rnd.Next(1, 8);
            pb2.Left += rnd.Next(1, 8);
            pb3.Left += rnd.Next(1, 8);
            pb4.Left += rnd.Next(1, 8);

            if(pb1.Left >= this.Width - pb1.Width)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. At kazandı!");
            }
            if (pb2.Left >= this.Width - pb2.Width)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. At kazandı!");
            }
            if (pb3.Left >= this.Width - pb3.Width)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. At kazandı!");
            }
            if (pb4.Left >= this.Width - pb4.Width)
            {
                timer1.Enabled = false;
                MessageBox.Show("4. At kazandı!");
            }
        }
    }
}
