using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4.exemploTriagulo
{
    public class Triangulo
    {
        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}