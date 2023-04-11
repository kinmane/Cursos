/*
*   31) Escrever um programa que leia um conjunto de números positivos, e exiba
*   se o número lido é par ou ímpar. Exiba ao final a soma total dos números
*   pares lidos e também a soma dos números ímpares lidos. Suporemos que o número
*   de elementos deste conjunto não é conhecido, e que um número negativo será
*   utilizado para sinalizar o fim dos dados.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer31
    {
        static void Main(string[] args)
        {
            int num, sumEven = 0, sumOdd = 0;

            while (true)
            {
                Console.WriteLine("Informe um número positivo (ou um número negativo para encerrar): ");
                num = int.Parse(Console.ReadLine());

                if (number < 0) break;

                if (num % 2 == 0)
                {
                    Console.WriteLine($"O número {num} é par!");
                    sumEven += num;
                }
                else
                {
                    Console.WriteLine($"O número {num} é ímpar!");
                    sumOdd += num;
                }
            }

            Console.WriteLine($"A soma dos números pares é: {sumEven}");
            Console.WriteLine($"A soma dos números ímpares é: {sumOdd}");
        }
    }
}