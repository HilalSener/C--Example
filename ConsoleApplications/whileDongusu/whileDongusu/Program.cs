using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana 5 defa Merhaba .Net yazdıran uygulama
            //int i = 0;
            //for (; i < 5 ;)
            //{
            //    Console.WriteLine("Merhaba .Net");
            //    i++;
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Merhaba .Net");
            //    i++;
            //}

            //başlangıç ve bitiş değerleri klavyeden girildiğindei girilen sayılar arasındaki değerleri ekranda alt alta gösteren uygulamayı yazınız.(Hem for hem de while ile)
            Console.Write("Başlangıç değerini giriniz: ");
            int deger1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş değerini giriniz: ");
            int deger2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Artış değerini giriniz: ");
            int artis = Convert.ToInt32(Console.ReadLine());

            //for (int i = deger1; i <= deger2; i = i + artis)
            //{
            //    Console.WriteLine(i);
            //}

            int i = deger1;
            while(i<=deger2)
            {
                Console.WriteLine(i);
                i += artis;
            }

            Console.ReadKey();
        }
    }
}