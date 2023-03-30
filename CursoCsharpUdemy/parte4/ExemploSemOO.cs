using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4
{
    public class ExemploSemOO
    {
        static void Main(string[] args)
        {
            double a, b, c, p, areaX, areaY;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            p = (a + b + c) / 2;
            areaX = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            
            p = (a + b + c) / 2;
            areaY = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

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