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
    public partial class frmSortedList : Form
    {
        public frmSortedList()
        {
            InitializeComponent();
        }

        SortedList slist = new SortedList();
        private void frmSortedList_Load(object sender, EventArgs e)
        {
            //Değerlerin anahtarlar ile eşleştirilerek kullanılmasını sağlar. Aynı anahtardan tekrar giriş yapılamaz.
            slist.Add("Selim", 18);
            slist.Add("Oya", 28);
            slist.Add("Hasan", 33);
            slist.Add("Ömer", 17);
            slist.Add("Ayşe", 24);
            slist.Add("İhsan", 22);
            slist.Add("Sinan", 30);
            slist.Add("Ali", 27);
            //slist.Add("Oya", 20); //Aynı anahtar tekrar girilemez (unique-tekil).
            slist["Oya"] = 20; //Önceden girilen anahtara karşılık gelen değeri değiştirdik.

            foreach (string isim in slist.Keys)
            {
                MessageBox.Show(isim);
            }

            foreach (int yas in slist.Values)
            {
                MessageBox.Show(yas.ToString());
            }

            int Yasi = (int)slist["Sinan"];
            MessageBox.Show("Yaşı: " + Yasi);

            if (slist.ContainsKey("Oya")) MessageBox.Show("Aradığınız kişi kayıtlı");
            else
                MessageBox.Show("Aradığınız kişi kayıtlı değil");

            foreach (DictionaryEntry ikili in slist)
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
