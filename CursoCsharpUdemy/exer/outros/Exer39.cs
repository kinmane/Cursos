/*
*   39) Faça um programa que leia um número inteiro e mostre uma mensagem
*   indicando se este número é par ou ímpar, e se é positivo ou negativo. O
*   programa só deve parar de rodar quando o usuário responder "S" na seguinte
*   pergunta, "Deseja encerrar o programa?" .
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer39
    {
        public static void Main (string[] args) {
            int num;

            do {
                Console.Write("Digite um número inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.Write("O número " + num + " é par e ");
                }
                else
                {
                    Console.Write("O número " + num + " é ímpar e ");
                }

                if (num > 0)
                {
                    Console.WriteLine("positivo.");
                }
                else if
                (num < 0) {
                    Console.WriteLine("negativo.");
                }
                else
                {
                    Console.WriteLine("zero.");
                }

                Console.Write("Deseja encerrar o programa? (S/N) ");
            } while (!Console.ReadLine().Equals("S", StringComparison.OrdinalIgnoreCase));
        }
    }
}