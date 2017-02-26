using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba .Net");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Console");

            Console.Write("Adınızı giriniz: ");
            string Ad = Console.ReadLine();

            Console.WriteLine("Hoşgeldin " + Ad);

            Console.ReadKey();
        }
    }
}
