using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4.exer.exer01
{
    public class Retangulo
    {
        double Width, Height, Area, Perimeter, Diagonal;

        public Area()
        {
           return Width * Height;
        }

        public Perimeter()
        {
            return 2 * (Width + Height);
        }

        public Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
    }
}