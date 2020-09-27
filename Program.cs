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
            Console.WriteLine("Hány számnak az átlagára kíváncsi?");
            int db= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Kérem a {0}. számot",i+1);
                ossz += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("A számok átlaga: "+ossz/db);



            Console.ReadLine();
        }
    }
}
