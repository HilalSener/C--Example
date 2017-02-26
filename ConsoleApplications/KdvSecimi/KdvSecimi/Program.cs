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
            basla:
            Console.Write("Malın fiyatunı giriniz: ");
            float Fiyat = Convert.ToSingle(Console.ReadLine());

            menu:
            Console.WriteLine("Kdv Menüsü \n 1. Gıda ürünleri %1 \n 2. Sağlık Ürünleri %8 \n 3. Diğer Ürünleri %18");
            Console.Write("Seçiminiz: ");
            int Secim = Convert.ToInt32(Console.ReadLine());

            float Kdv, ToplamFiyat;
            if (Secim == 1)
            {
                Kdv = Fiyat * 1 / 100;
                ToplamFiyat = Kdv + Fiyat;
                Console.WriteLine("Fiyat: {0}, Kdv: {1}, Toplam fiyat: {2}", Fiyat, Kdv, ToplamFiyat);
            }
            else if (Secim == 2)
            {
                Kdv = Fiyat * 8 / 100;
                ToplamFiyat = Kdv + Fiyat;
                Console.WriteLine("Fiyat: {0}, Kdv: {1}, Toplam fiyat: {2}", Fiyat, Kdv, ToplamFiyat);
            }
            else if (Secim == 3)
            {
                Kdv = Fiyat * 18 / 100;
                ToplamFiyat = Kdv + Fiyat;
                Console.WriteLine("Fiyat: {0}, Kdv: {1}, Toplam fiyat: {2}", Fiyat, Kdv, ToplamFiyat);
            }
            else
            {
                Console.WriteLine("1-3 arasında seçim yapınız!");
                Console.WriteLine();
                goto menu;
            }

            Console.WriteLine();
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
        }
    }
}
