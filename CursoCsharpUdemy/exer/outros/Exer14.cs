/*
*   14) Escreva um programa que leia dois números e apresente a diferença do
*   maior para o menor.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int diff = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine("A diferença entre o maior e o menor é: " + diff);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("A diferença entre o maior e o menor é: " + diff);
            }
            else
            {
                Console.WriteLine("Os números são iguais, a diferença é 0.");
            }
        }
    }
}