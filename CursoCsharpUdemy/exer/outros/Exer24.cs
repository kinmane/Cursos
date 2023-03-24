/*
*   24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
*   realizar:
*   1 – Verificar se um dos números lidos é ou não múltiplo do outro
*   2 – Verificar se os dois números lidos são pares
*   3 – Verificar se a média dos dois números é maior ou igual a 7.
*   4 – Sair
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer24
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            do {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números são pares");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção escolhida: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                if (num1 % num2 == 0 || num2 % num1 == 0) {
                    Console.WriteLine("\nUm dos números é múltiplo do outro");
                } else {
                    Console.WriteLine("\nOs números não são múltiplos entre si");
                }
                break;

                case 2:
                if (num1 % 2 == 0 && num2 % 2 == 0) {
                    Console.WriteLine("\nOs dois números são pares");
                } else {
                    Console.WriteLine("\nPelo menos um dos números é ímpar");
                }
                break;

                case 3:
                double media = (num1 + num2) / 2.0;
                if (media >= 7) {
                    Console.WriteLine("\nA média dos números é maior ou igual a 7");
                } else {
                    Console.WriteLine("\nA média dos números é menor do que 7");
                }
                break;

                case 4:
                Console.WriteLine("\nPrograma encerrado.");
                break;

                default:
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
            }

            } while (opcao != 4);
        }
    }
}