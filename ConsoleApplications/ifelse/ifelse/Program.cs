using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen iki sayıdan büyük olanı ekranda Büyük sayı: sayı şeklinde gösteren uygulamayı yazınız.
            Console.Write("1.Sayıyı giriniz: ");
            int Sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            int Sayi2 = Convert.ToInt32(Console.ReadLine());

            if (Sayi1 > Sayi2)
                Console.Write("Büyük sayı: " + Sayi1);
                //Console.WriteLine(Sayi1 + " > " + Sayi2);
            else
                Console.Write("Büyük sayı: " + Sayi2);
                //Console.WriteLine(Sayi2 + " > " + Sayi1);

            Console.ReadKey();
        }
    }
}
