using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    internal class Krog
    {
        private int r;

        public Krog()
        {
            this.r = 1;
        }

        public Krog(int r)
        {
            this.r = r;
        }

        public void NastaviR(int novR)
        {
            if (novR > 0)
            {
                r = novR;
            }
            else
            {
                Console.WriteLine("Polmer mora biti pozitivno število.");
            }
        }




    }
}
