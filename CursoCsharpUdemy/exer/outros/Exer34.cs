/*
*   34) Escreva um programa que leia um conjunto de números positivos e exiba o
*   menor e o maior. Suporemos que o número de elementos deste conjunto não é
*   conhecido, e que um número negativo será utilizado para sinalizar o fim dos
*   dados.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer34
    {
        static void Main(string[] args)
        {
            int num, min = Integer.MaxValue, max = Integer.MinValue;

            while (true)
            {
                Console.Write("Digite um número positivo (negativo para encerrar): ");
                num = int.Parse(Console.ReadLine());

                if (number < 0) break;

                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"O menor número é: {min}");
            Console.WriteLine($"O maior número é: {max}");
        }
    }
}