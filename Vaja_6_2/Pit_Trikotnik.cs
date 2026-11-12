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
        public void NastavitevVrednosti(double pr_a, double pr_b, double pr_c)
        {
            a = pr_a;
            b= pr_b;
            c = pr_c;

        }
        public double Obseg()
        {
            return a + b + c;
        }

        public double Ploscina()
        {
            return (a * b) / 2;
        }



    }
}
