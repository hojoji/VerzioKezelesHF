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
            Console.WriteLine("Hány számnak az átlagára kíváncsi?");
            int db= Convert.ToInt32(Console.ReadLine());

            int ossz = 0;
            int bekert;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Kérem a {0}. számot",i+1);
                bekert = Convert.ToInt32(Console.ReadLine());
                ossz += bekert;
                if (bekert<min)
                {
                    min = bekert;
                }
                if (bekert > max)
                {
                    max = bekert;
                }

            }
            Console.WriteLine("A számok átlaga: " + ossz*1.0 / db);
            Console.WriteLine("A legkisseb szám: "+min);
            Console.WriteLine("A legnagyobb szám: " + max);




            Console.ReadLine();
        }
    }
}
