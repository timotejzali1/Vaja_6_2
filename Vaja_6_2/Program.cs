using System;

namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pit_Trikotnik t = new Pit_Trikotnik(6, 8);

            Console.WriteLine("Ploscina trikotnika je:" + t.Ploscina());

            Krog krog1 = new Krog(5);

            Krog krog2 = new Krog();
            krog2.NastaviR(6);

            Console.WriteLine($"Ploščina prvega kroga (r = 5): {krog1.Ploscina():F2}");
            Console.WriteLine($"Ploščina drugega kroga (r = 6): {krog2.Ploscina():F2}");

            Console.ReadKey();
            Pravokotnik pravokotnik1 = new Pravokotnik(3, 3);
            Pravokotnik pravokotnik2 = new Pravokotnik(6, 4);

            Console.WriteLine("Rectangle 1 area: " + pravokotnik1.Ploscina());
            Console.WriteLine("Rectangle 2 area: " + pravokotnik2.Ploscina());
        }
    }
}
