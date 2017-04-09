using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_kutuphane
{
    public partial class frmKitapTurleri : Form
    {
        public frmKitapTurleri()
        {
            InitializeComponent();
        }

        private void frmKitapTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cKitapTuru kt = new cKitapTuru();
            txtID.Text = kt.SonIDBul().ToString();
            kt.KitapTurleriGoster(lbKitapTurleri);
            txtKitapTuru.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtKitapTuru.Text.Trim() != null)
            {
                cKitapTuru kt = new cKitapTuru();
                if (kt.KitapTuruVarmi(txtKitapTuru.Text))
                    MessageBox.Show("Daha önceden kayıtlı!", "Zaten Var!");
                else
                {
                    kt.Id = Convert.ToInt32(txtID.Text);
                    kt.KitapTuru = txtKitapTuru.Text;
                    if (kt.KitapTuruEkle(kt))
                    {
                        MessageBox.Show("Kitap Türü Eklendi.");
                        txtKitapTuru.Clear();
                        txtID.Text = kt.SonIDBul().ToString();
                        kt.KitapTurleriGoster(lbKitapTurleri);
                        txtKitapTuru.Focus();
                    }
                }
            }
        }
    }
}
