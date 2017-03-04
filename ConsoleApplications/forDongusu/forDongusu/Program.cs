using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana alt alta 5 defa Merhaba .Net yazısını görüntüleyen uygulamayı yazınız.
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine("Merhaba .Net");

            //1 - 10 sayıları alt alta gösteren uygulama
            //for (int i=1; i<=10; i++)
            //    Console.WriteLine(i);

            //for (int i = 1; i <= 10; i+=2)
            //    Console.WriteLine(i);
            //Console.WriteLine();

            //for (int i = 0; i <= 10; i += 2)
            //    Console.WriteLine(i);
            //Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
