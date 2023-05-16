using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.For
{
    public class Exer07
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Informe um número: ");

            for (int i = 1; i <= n; i++) {
                int value = i;
                int square = i * i;
                int cube = i * i * i;
                Console.WriteLine($"{value} {square} {cube}");
            }
        }
    }
}