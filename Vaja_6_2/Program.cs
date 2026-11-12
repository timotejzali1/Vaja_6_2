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
            Pit_Trikotnik t = new Pit_Trikotnik(6, 8);

            Console.WriteLine("Ploscina trikotnika je:" + t.Ploscina());

        }
    }
}
