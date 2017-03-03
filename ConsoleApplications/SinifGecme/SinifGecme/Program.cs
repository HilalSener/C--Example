using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifGecme
{
    class Program
    {
        static void Main(string[] args)
        {
            //alınan iki notun ortalamasını hesaplayıp 50 den büyük ve eşitse geçti, değilse kaldı. 90 - 100 arası A ile geçti. 80-90 B. 80-70 C. 70-60 D. 60-50 E gibi.
            Console.Write("1.Notu giriniz: ");
            int Not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Notu giriniz: ");
            int Not2 = Convert.ToInt32(Console.ReadLine());

            int Ortalama = (Not1 + Not2) / 2;

            if (Ortalama > 50)
                Console.WriteLine("Geçti!");
            else
                Console.WriteLine("Kaldı");

        }
    }
}
