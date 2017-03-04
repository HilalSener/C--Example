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
            float Not1 = Convert.ToSingle(Console.ReadLine());
            //if (Not1 > 100)
            //{
            //    Console.WriteLine("Not1 100 den büyük olamaz!");
            //    goto basla;
            //}
            //else if(Not1 < 0)
            //{
            //    Console.WriteLine("Not1 0 dan küçük olamaz!");
            //    goto basla;
            //}

            //NotGiris2:
            Console.Write("2.Notu giriniz: ");
            float Not2 = Convert.ToSingle(Console.ReadLine());
            //if (Not2 > 100)
            //{
            //    Console.WriteLine("Not2 100 den büyük olamaz!");
            //    goto NotGiris2;
            //}
            //else if (Not2 < 0)
            //{
            //    Console.WriteLine("Not2 0 dan küçük olamaz!");
            //    goto NotGiris2;
            //}

            float Ortalama = (Not1 + Not2) / 2f;

            //if (Ortalama > 50)
            //    Console.WriteLine("Geçti!");
            //else
            //    Console.WriteLine("Kaldı");

            if (Not1 > 0 && Not1 < 100 && Not2 > 0 && Not2 <100)
            {
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
            }
            else
            {
                Console.WriteLine("Notlar 0 - 100 arasında girilmelidir!");
                goto basla;
            }
           
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
