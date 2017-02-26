using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //my solution
            //Console.Write("1.sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi1 + sayi2;
            //Console.WriteLine(sayi1 + " + " + sayi2 + " = " + toplam);

            //Console.ReadLine();

            //the other solution
            Console.Write("1.Sayıyı giriniz: ");
            string Sayi1 = Console.ReadLine();

            Console.Write("2.Sayıyı giriniz: ");
            string Sayi2 = Console.ReadLine();

            int S1, S2;
            S1 = int.Parse(Sayi1);
            S2 = int.Parse(Sayi2);
            int T = S1 + S2;

            //Console.WriteLine("Toplam = " + (S1 + S2));
            //Console.WriteLine("Toplam = " + T);
            //Console.WriteLine("1.Sayı : {0} ve 2.Sayı : {1} toplamı = {2}", S1, S2, T);
            //Console.WriteLine("{0} + {1} = {2}", S1, S2, S1 + S2);
            Console.WriteLine("{0} + {1} = {2}", S1, S2, T);

            Console.ReadKey();
        }
    }
}
