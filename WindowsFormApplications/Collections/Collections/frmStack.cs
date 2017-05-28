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
    public partial class frmStack : Form
    {
        public frmStack()
        {
            InitializeComponent();
        }

        Stack stack = new Stack();

        private void frmStack_Load(object sender, EventArgs e)
        {
            int[] Sayilar = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < Sayilar.Length; i++)
            {
                stack.Push(Sayilar[i]);
            }
            foreach (object eleman in stack)
            {
                lbList1.Items.Add(eleman);
            }
            while (stack.Count > 0)
            {
                lbList2.Items.Add(stack.Pop());
            }
            //Tüm elemanlar yığından çıkarıldıktan sonra stack.count = 0 olur
        }
    }
}
