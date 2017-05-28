using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class frmHashTable : Form
    {
        public frmHashTable()
        {
            InitializeComponent();
        }

        Hashtable htable = new Hashtable();

        private void frmHashTable_Load(object sender, EventArgs e)
        {
            //Değerlerin anahtarlar ile eşleştirilerek kullanılmasını sağlar. Aynı anahtardan tekrar giriş yapılamaz.
            htable.Add("Selim", 18);
            htable.Add("Oya", 28);
            htable.Add("Hasan", 33);
            htable.Add("Ömer", 17);
            htable.Add("Ayşe", 24);
            htable.Add("İhsan", 22);
            htable.Add("Sinan", 30);
            htable.Add("Ali", 27);
            htable.Add("Oya", 20); //Aynı anahtar tekrar girilemez (unique-tekil).
            htable["Oya"] = 20; //Önceden girilen anahtara karşılık gelen değeri değiştirdik.

            foreach (string isim in htable.Keys)
            {
                MessageBox.Show(isim);
            }

            foreach (int yas in htable.Values)
            {
                MessageBox.Show(yas.ToString());
            }

            int Yasi = (int)htable["Sinan"];
            MessageBox.Show("Yaşı: " + Yasi);

            if (htable.ContainsKey("Oya")) MessageBox.Show("Aradığınız kişi kayıtlı");
            else
                MessageBox.Show("Aradığınız kişi kayıtlı değil");

            foreach (DictionaryEntry ikili in htable)
            {
                string isim = (string)ikili.Key;
                lbList1.Items.Add(isim);
                int yas = (int)ikili.Value;
                lbList2.Items.Add(yas);
                int kod = ikili.GetHashCode();
                lbList3.Items.Add(kod);
            }
        }
    }
}
