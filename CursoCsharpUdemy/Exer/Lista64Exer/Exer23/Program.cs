/*
 * 23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
 * 1 – Adição
 * 2 – Subtração
 * 3 – Multiplicação
 * 4 – Divisão 
 */

namespace Exer23
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            double n1 = 0;
            double n2 = 0;

            System.Console.WriteLine("1 – Adição");
            System.Console.WriteLine("2 – Subtração");
            System.Console.WriteLine("3 – Multiplicação");
            System.Console.WriteLine("4 – Divisão");
            System.Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o segundo número: ");
            n2 = double.Parse(System.Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    System.Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, n1 + n2);
                    break;
                case 2:
                    System.Console.WriteLine("A subtração de {0} e {1} é {2}", n1, n2, n1 - n2);
                    break;
                case 3:
                    System.Console.WriteLine("A multiplicação de {0} e {1} é {2}", n1, n2, n1 * n2);
                    break;
                case 4:
                    System.Console.WriteLine("A divisão de {0} e {1} é {2}", n1, n2, n1 / n2);
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}