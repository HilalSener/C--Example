using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - 10 a kadar sayıları ekranda alt atla listleyen ve sonunda da bu sayıların toplamını gösteren uygulamayı yazınız.
            int Toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Toplam = Toplam + i;
            }
            Console.WriteLine("Toplam: " + Toplam);
            Console.ReadKey();
        }
    }
}
