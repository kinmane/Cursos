using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer37
    {
        static void Main(string[] args)
        {
            int operation = 0;

            do
            {
                Console.WriteLine("Selecione a operação desejada:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        double num1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double num2 = double.Parse(Console.ReadLine());

                        double resultado = num1 + num2;

                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 2:
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = num1 - num2;

                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 3:
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = num1 * num2;

                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());

                        if (num2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero!");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine();

            } while (operation != 5);
        }
    }
}