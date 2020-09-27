using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
           int ossz = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kérem a {0}. számot",i+1);
                ossz += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("A számok átlaga: "+ossz/10);

            Console.ReadLine();
        }
    }
}
