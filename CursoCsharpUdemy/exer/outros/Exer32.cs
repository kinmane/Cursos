/*
*   32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros
*   números inteiros positivos ímpares a partir do número informado pelo usuário menor que 10
*   e maior que zero.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer32
    {
        static void Main(string[] args)
        {
            int sumSquare = 0, countOdd = 0, num;

            Console.WriteLine("Informe o número inteiro, menor que 10 e maior que 0: ");
            num = int.Parse(Console.ReadLine());

            sumSquare = 0;
            countOdd = 0;

            for (int i = num; countOdd < 20; i++)
            {
                if (i % 2 != 0)
                {
                    sumSquare += i * i;
                    countOdd++;
                }
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números inteiros positivos ímpares de {num} é: {sumSquare}");
        }
    }
}