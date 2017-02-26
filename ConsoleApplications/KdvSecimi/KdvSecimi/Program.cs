using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdvSecimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Malın fiyatunı giriniz: ");
            float Fiyat = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Kdv Menüsü \n 1. Gıda ürünleri %1 \n 2. Sağlık Ürünleri %8 \n 3. Diğer Ürünleri %18");
            Console.Write("Seçiminiz: ");
            int Secim = Convert.ToInt32(Console.ReadLine());

            float Kdv, ToplamFiyat;
            if (Secim == 1)
            {
                Kdv = Fiyat * 1 / 100;
                ToplamFiyat = Kdv + Fiyat;
                Console.WriteLine(ToplamFiyat);
            }
            else if (Secim == 2)
            {
                Kdv = Fiyat * 8 / 100;
                ToplamFiyat = Kdv + Fiyat;
                Console.WriteLine(ToplamFiyat);
            }
            else if (Secim == 3)
            {
                Kdv = Fiyat * 18 / 100;
                ToplamFiyat = Kdv + Fiyat;
                Console.WriteLine(ToplamFiyat);
            }
            Console.ReadLine();
        }
    }
}
