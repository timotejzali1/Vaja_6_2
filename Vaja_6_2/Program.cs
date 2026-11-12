using System;

namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik pravokotnik1 = new Pravokotnik(3, 3);
            Pravokotnik pravokotnik2 = new Pravokotnik(6, 4);

            Console.WriteLine("Rectangle 1 area: " + pravokotnik1.Ploscina());
            Console.WriteLine("Rectangle 2 area: " + pravokotnik2.Ploscina());
        }
    }
}
