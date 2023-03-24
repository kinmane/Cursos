/*
*   23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada
* uma delas:
*   1 – Adição
*   2 – Subtração
*   3 – Multiplicação
*   4 – Divisão
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer23
    {
        static void Main(string[] args)
        {
            int option = 0;
            double result = 0;

            do
            {
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                option = int.Parse(Console.ReadLine());

                Console.Write("\nInforme o primeiro valor:");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o segundo valor:");
                int number2 = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        result = number1 + number2;
                        System.Console.WriteLine("Resultado: " + result);
                        System.Console.WriteLine("");
                        break;
                    case 2:
                        result = number1 - number2;
                        System.Console.WriteLine("Resultado: " + result);
                        System.Console.WriteLine("");
                        break;
                    case 3:
                        result = number1 * number2;
                        System.Console.WriteLine("Resultado: " + result);
                        System.Console.WriteLine("");
                        break;
                    case 4:
                        result = number1 / number2;
                        if (number2 == 0)
                        {
                            System.Console.WriteLine("Impossível dividir por Zero");
                        }
                        else
                        {
                            System.Console.WriteLine("Resultado: " + result);
                            System.Console.WriteLine("");
                        }
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }
                
            } while (option != 0);
        }
    }
}