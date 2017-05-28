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
    public partial class frmArrayList : Form
    {
        public frmArrayList()
        {
            InitializeComponent();
        }

        ArrayList alist = new ArrayList();

        private void frmArrayList_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(alist.Capacity.ToString());
            alist.Add(1);
            alist.Add(2);
            alist.Add(3);
            alist.Add(4);
            alist.Add(5);
            //MessageBox.Show(alist.Capacity.ToString());
            alist.Add(6);
            alist.Add(7);
            alist.Add(8);

            foreach (object eleman in alist)
            {
                //lbList1.Items.Add(eleman);
                lbList1.Items.Add(Convert.ToInt32(eleman));
            }
            alist.Insert(6, 10);
            MessageBox.Show("Kapasite: " + alist.Capacity);
            MessageBox.Show("Eleman Sayısı: " + alist.Count);

            foreach (object eleman in alist)
            {
                lbList2.Items.Add(Convert.ToInt32(eleman));
            }
            alist.Remove(5);  //Değeri 5 olan elemanı siler. Diğerlerini kaydırır

            foreach (int eleman in alist)
            {
                lbList3.Items.Add(eleman);
            }
            alist.RemoveAt(5); //5. sıradaki elemanı siler

            foreach (int eleman in alist)
            {
                lbList4.Items.Add(eleman);
            }
            MessageBox.Show("Kapasite: " + alist.Capacity);
            MessageBox.Show("Eleman Sayısı: " + alist.Count);
            //ArrayList' in içinde kalan değerlerin toplamı

            int Toplam = 0;
            foreach (object eleman in alist)
            {
                Toplam += Convert.ToInt32(eleman);
            }
            MessageBox.Show("Toplam: " + Toplam);

            for (int i = 0; i < alist.Count; i++)
            {
                Toplam += Convert.ToInt32(alist[i]);
            }
            MessageBox.Show("Toplam: " + Toplam);
        }
    }
}
