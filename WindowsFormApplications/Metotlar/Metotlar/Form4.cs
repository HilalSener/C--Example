using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int a = 5; //Value type; Stack hafızada tutuluyor.
            MessageBox.Show(a.ToString());
            //DegerAl(a);
            //DegerAl(ref a);
            DegerAl(out a);
            MessageBox.Show(a.ToString());

            //string Sehir = "Izmir";
            //MessageBox.Show(Sehir.ToString());
            //ReferansAl(Sehir);
            //MessageBox.Show(Sehir.ToString());

            string[] Sehirler = { "İzmir", "Ankara", "Bursa", "Adana"}; //Referans type; "string[], object" heap hafızada tutuluyor.
            MessageBox.Show(Sehirler[0]);
            ReferansAl(Sehirler);
            MessageBox.Show(Sehirler[0]);

            //Değer tipli değişkenlerin içindekiler bit bit metotlara aktarılırken referans tipli değişkenlerin adresleri aktarılır. Bu nedenle value type değişkenlerin kendi deeğerleri metot içindeki eğişimlerden etkinlenmezken, referans tipli(string dizi, object) değişkenlerin adresleri aktarıldığından metotlardaki değişiklikler de aynı adres üzerinde gerçekleşir ve değişkenlerin orjinal değerleri de değişir 
            //Eğer valuse type değişkenlerin de adresleri dikkate alınmak istenirse önlerine ref eki getirilmelidir. Ancak bu durumda da kullanılmadan önce value type değişkene mutlaka bir ilk değer atanmış olmalıdır. 
            //Eğer "ref" yerine "out" ön eki kullanılırsa ilk değer verilmeden de value type değişkenlerin adresleri referans type değişkenlerdeli gibi işleme sokulur.
        }

        //private void DegerAl(int a)
        //{
        //    a = 10;
        //}

        //private void DegerAl(ref int a)
        //{
        //    a = 10;
        //}

        private void DegerAl(out int a)
        {
            a = 10;
        }

        private void ReferansAl(string[] Iller)
        {
            Iller[0] = "İstanbul";
        }

        //private void ReferansAl(string Sehir)
        //{
        //    Sehir = "Istanbul"; 
        //}
    }
}
