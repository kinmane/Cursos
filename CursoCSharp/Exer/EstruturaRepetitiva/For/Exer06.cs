using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.For
{
    public class Exer06
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    }
}