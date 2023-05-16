using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.For
{
    public class Exer05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("O fatorial de " + number + " é " + factorial);
        }
    }
}