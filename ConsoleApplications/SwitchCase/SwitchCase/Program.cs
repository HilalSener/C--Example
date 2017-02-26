using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden mevsim bilgisi girildiğinde o mevsime ait ayları gösteren uygulamayı yazınız.

            //if ile çözüm
            //Console.Write("Bir mevsim giriniz: ");
            //string Mevsim = Console.ReadLine();

            //if (Mevsim == "Sonbahar")
            //    Console.WriteLine("Eylül \nEkim \nKasım");
            //else if (Mevsim == "Kış")
            //    Console.WriteLine("Aralık \nOcak \nŞubat");
            //else if (Mevsim == "İlkbahar")
            //    Console.WriteLine("Mart \nNisan \nMayıs");
            //else if (Mevsim == "Yaz")
            //    Console.WriteLine("Haziran \nTemmuz \nAğustos");
            //else
            //    Console.WriteLine("Hatalı mevsim girişi!");

            //Console.ReadKey();

            //switch-case ile çözüm
            Console.Write("Bir mevsim giriniz: ");
            string Mevsim = Console.ReadLine();

            switch(Mevsim)
            {
                case "Sonbahar":
                    Console.WriteLine("Eylül \nEkim \nKasım");
                    break;
                case "Kış":
                    Console.WriteLine("Aralık \nOcak \nŞubat");
                    break;
                case "İlkbahar":
                    Console.WriteLine("Mart \nNisan \nMayıs");
                    break;
                case "Yaz":
                    Console.WriteLine("Haziran \nTemmuz \nAğustos");
                    break;
                default:
                    Console.WriteLine("Hatalı mevsim girişi!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
