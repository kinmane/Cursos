using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4.exer.exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.Width = double.Parse(Console.ReadLine());
            retangulo.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimeter().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}