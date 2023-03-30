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
            x.a = double.Parse(Console.ReadLine());
            x.b = double.Parse(Console.ReadLine());
            x.c = double.Parse(Console.ReadLine());

            p = (x.a + x.b + x.c) / 2;
            areaX = Math.Sqrt(p * (p - x.a) * (p - x.b) * (p - x.c));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.a = double.Parse(Console.ReadLine());
            y.b = double.Parse(Console.ReadLine());
            y.c = double.Parse(Console.ReadLine());
            
            p = (y.a + y.b + y.c) / 2;
            areaY = Math.Sqrt(p * (p - y.a) * (p - y.b) * (p - y.c));

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