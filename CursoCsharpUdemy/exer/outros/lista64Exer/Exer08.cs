/*
*   8) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
*   V = 3.14159 * R * R * A
*   Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir o raio: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserir a altura: ");
            double height = double.Parse(Console.ReadLine());

            double volume = 3.14159 * radius * radius * height;

            Console.WriteLine("O volume da lata de óleo: " + volume.ToString("F2"));
        }
    }
}