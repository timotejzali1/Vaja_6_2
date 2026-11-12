using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog krog1 = new Krog(5);

            Krog krog2 = new Krog();
            krog2.NastaviR(6);

            Console.WriteLine($"Ploščina prvega kroga (r = 5): {krog1.Ploscina():F2}");
            Console.WriteLine($"Ploščina drugega kroga (r = 6): {krog2.Ploscina():F2}");

            Console.ReadKey();
        }
    }
}
