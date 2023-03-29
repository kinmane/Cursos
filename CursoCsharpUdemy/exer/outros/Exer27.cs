/*
*   27) Escreva um programa que leia: - a quantidade de números que deverá
*   processar; - os números que deverá processar,e calcule e exiba, para cada
*   número a ser processado o seu fatorial. Lembrete: O fatorial de um número N é
*   dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer27
    {
        static void Main(string[] args)
        {
            int qty, number;
            long factorial;

            Console.WriteLine("Escreva a quantidade de números que deverá processar: ");
            qty = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qty; i++)
            {
                Console.WriteLine("Digite o {0}º número: ", i);
                number = int.Parse(Console.ReadLine());
                factorial = 1;

                for (int j = 1; j <= number; j++) {
                    factorial *= j;
                }

                console.WriteLine("O fatorial de {0} é: {1}", number, factorial);
            }
        }
    }
}