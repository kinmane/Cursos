/*
*   Faça um programa para imprimir uma tabuada.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número que quer saber a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}