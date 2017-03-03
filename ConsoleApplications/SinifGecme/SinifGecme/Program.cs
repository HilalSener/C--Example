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
            basla:
            Console.Write("1.Notu giriniz: ");
            int Not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Notu giriniz: ");
            int Not2 = Convert.ToInt32(Console.ReadLine());

            float Ortalama = (Not1 + Not2) / 2f;

            //if (Ortalama > 50)
            //    Console.WriteLine("Geçti!");
            //else
            //    Console.WriteLine("Kaldı");

            if (Ortalama >= 90)
                Console.WriteLine("{0}, A ile geçti!", Ortalama);
            else if (Ortalama >= 80)
                Console.WriteLine("{0}, B ile geçti!", Ortalama);
            else if (Ortalama >= 70)
                Console.WriteLine("{0}, C ile geçti!", Ortalama);
            else if (Ortalama >= 60)
                Console.WriteLine("{0}, D ile geçti", Ortalama);
            else if (Ortalama >= 50)
                Console.WriteLine("{0}, E ile geçti", Ortalama);
            else if (Ortalama < 50)
                Console.WriteLine("{0}, F ile Kaldı", Ortalama);

            Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
            string Cevap = Console.ReadLine();

            if (Cevap.ToUpper() == "E")
            {
                Console.WriteLine();
                Console.Clear();
                goto basla;
            }
            else
                Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
