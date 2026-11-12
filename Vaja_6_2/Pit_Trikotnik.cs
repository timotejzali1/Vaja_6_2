using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    internal class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;


        public Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c= 5;

        }

        public Pit_Trikotnik(double pr_a, double pr_b)
        {
            a= pr_a;
            b= pr_b;
            c =Math.Sqrt(a*a + b*b);
        }


    }
}
