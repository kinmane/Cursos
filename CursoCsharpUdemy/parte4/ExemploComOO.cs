using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploClassTriangulo;

namespace parte4
{
    public class ExemploComOO
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            double areaX, areaY;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            p = (x.A + x.B + x.C) / 2;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            
            p = (y.A + y.B + y.C) / 2;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área do triângulo X: " + areaX.ToString("F3"));
            Console.WriteLine("Área do triângulo Y: " + areaY.ToString("F3"));

            if (areaX > areaY)
            {
                Console.WriteLine("Triângulo X é maior que triângulo Y");
            }
            else
            {
                Console.WriteLine("Triângulo Y é maior que triângulo X");
            }
        }
    }
}