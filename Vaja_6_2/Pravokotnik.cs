using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    internal class Pravokotnik
    {
        private double a;
        private double b;

        public Pravokotnik()
        {
            a = 1;
            b = 1;
        }

        public Pravokotnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Nastavi(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
