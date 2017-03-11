using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySeven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(1, 9).ToString();
            label2.Text = rnd.Next(1, 9).ToString();
            label3.Text = rnd.Next(1, 9).ToString();
        }

        int Hak = 10;
        private void btnGame_Click(object sender, EventArgs e)
        {
            if (btnGame.Text == "START")
            {
                timer1.Enabled = true;
                btnGame.Text = "STOP";
            }
            else
            {
                timer1.Enabled = false;
                btnGame.Text = "START";

                if (label1.Text == label2.Text && label2.Text == label3.Text)
                {
                    MessageBox.Show("Tebrikler Kazandın!", "WIN!, WIN!, WIN!");
                    Hak += 10;
                    label4.Text = Hak.ToString();
                }
                else if(label1.Text == label2.Text || label2.Text == label3.Text || label1.Text == label3.Text)
                {
                    MessageBox.Show("Tebrikler 2 tanesini doğru bildin!", "Oynamaya DEVAM!");
                    Hak += 3;
                    label4.Text = Hak.ToString();
                }
                else
                {
                    MessageBox.Show("Tekrar denemelisin ;)", "Şimdilik Olmadı...");
                    Hak--;
                    label4.Text = Hak.ToString();
                    if(Hak == 0)
                    {
                        MessageBox.Show("Hakkın doldu :(");
                    }
                }
            }
        }
    }
}
