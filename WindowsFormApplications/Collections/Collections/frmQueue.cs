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
    public partial class frmQueue : Form
    {
        public frmQueue()
        {
            InitializeComponent();
        }

        Queue kuyruk = new Queue(); //FIFO(First in first out - İlk giren ilk çıkar)

        private void frmQueue_Load(object sender, EventArgs e)
        {
            int[] Sayilar = { 2, 4, 6, 8, 10};
            for (int i = 0; i < Sayilar.Length; i++)
            {
                kuyruk.Enqueue(Sayilar[i]);
            }
            foreach (object eleman in kuyruk)
            {
                lbList1.Items.Add(eleman);
            }
            while(kuyruk.Count > 0)
            {
                lbList2.Items.Add(kuyruk.Dequeue());
            }
        }
    }
}
