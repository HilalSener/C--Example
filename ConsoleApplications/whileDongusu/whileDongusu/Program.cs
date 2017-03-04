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

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Merhaba .Net");
                i++;
            }
            Console.ReadKey();
        }
    }
}
