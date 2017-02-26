using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdvHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir malın fiyatı klavyeden girildiğinde %18 KDV' sini ve KDV' li Toplam fiyatını hesaplayıp gösteren konsol uygulamasını yazınız.
            Console.Write("Malın fiyatınızı giriniz: ");
            double Fiyat = Convert.ToDouble(Console.ReadLine());

            double Kdv = Fiyat * 18d / 100;
            //Console.WriteLine("Malın kdv' si = " + Kdv);

            double NetFiyat = Fiyat + Kdv;
            //Console.WriteLine("Malın toplam fiyatı = " + NetFiyat);

            Console.WriteLine("Malın fiyatı: {0}, Malın Kdv' si: {1}, Malın Kdv'li Toplam Fiyatı: {2}", Fiyat, Kdv, NetFiyat);

            Console.ReadLine(); 
        }
    }
}
