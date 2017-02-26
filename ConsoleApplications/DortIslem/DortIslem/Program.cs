using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen iki sayıya menüden seçilen işlemi uygulayıp sonucu ekrana yazdıran uygulamayı yazınız.
            basla:
            Console.Write("1.Sayıyı giriniz: ");
            int Sayi1= Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            int Sayi2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Toplama \n2.Çıkarma \n3.Çarpma \n4.Bölme");
            Console.Write("İşleminizi seçiniz: ");
            string Secim = Console.ReadLine();

            switch(Secim)
            {
                case "1":
                    Console.WriteLine(Sayi1 + "+" + Sayi2 + "=" + (Sayi1 + Sayi2));
                    break;
                case "2":
                    Console.WriteLine(Sayi1 + "-" + Sayi2 + "=" + (Sayi1 - Sayi2));
                    break;
                case "3":
                    Console.WriteLine(Sayi1 + "*" + Sayi2 + "=" + (Sayi1 * Sayi2));
                    break;
                case "4":
                    Console.WriteLine(Sayi1 + "/" + Sayi2 + "=" + (Sayi1 / Sayi2));
                    break;
            }
            Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
            string cevap = Console.ReadLine();
            if (cevap.ToUpper() == "E")
            {
                Console.WriteLine();
                Console.Clear();
                goto basla;
            }
            else if (cevap == "H")
                Environment.Exit(0);
            Console.ReadKey();
        }
    }
}