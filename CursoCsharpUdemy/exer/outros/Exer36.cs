/*
*   36) Faça um programa que leia 10 valores inteiros e positivos e: - Encontre o
*   maior valor - Encontre o menor valor - Calcule a média dos números lidos
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer36
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 1; i <= 10; i++) {
                Console.Write("Informe um número inteiro #" + i + ": ");
                int number = int.Parse(Console.ReadLine());

                while (number <= 0) {
                    Console.WriteLine("O número deve ser positivo! Tente novamente.");
                    Console.Write("Informe um número inteiro #" + i + ": ");
                    number = int.Parse(Console.ReadLine());
                }

                if (number < min) {
                    min = number;
                }
                if (number > max) {
                    max = number;
                }
                sum += number;
            }

            double average = (double) sum / 10;

            Console.WriteLine("Valor minimo: " + min);
            Console.WriteLine("Valor maximo: " + max);
            Console.WriteLine("Valor medio: " + average);
        }
    }
}