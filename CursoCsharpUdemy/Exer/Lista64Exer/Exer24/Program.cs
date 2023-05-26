/*
 * 24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
 * realizar:
 * 1 – Verificar se um dos números lidos é ou não múltiplo do outro
 * 2 – Verificar se os dois números lidos são pares
 * 3 – Verificar se a média dos dois números é maior ou igual a 7.
 * 4 – Sair 
 */

namespace Exer24
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int opcao = 0;

            System.Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o segundo número: ");
            n2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
            System.Console.WriteLine("2 – Verificar se os dois números lidos são pares");
            System.Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7.");
            System.Console.WriteLine("4 – Sair");
            System.Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(System.Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (n1 % n2 == 0 || n2 % n1 == 0)
                    {
                        System.Console.WriteLine("Um dos números é múltiplo do outro");
                    }
                    else
                    {
                        System.Console.WriteLine("Nenhum dos números é múltiplo do outro");
                    }
                    break;
                case 2:
                    if (n1 % 2 == 0 && n2 % 2 == 0)
                    {
                        System.Console.WriteLine("Os dois números são pares");
                    }
                    else
                    {
                        System.Console.WriteLine("Os dois números não são pares");
                    }
                    break;
                case 3:
                    if ((n1 + n2) / 2 >= 7)
                    {
                        System.Console.WriteLine("A média dos dois números é maior ou igual a 7");
                    }
                    else
                    {
                        System.Console.WriteLine("A média dos dois números é menor que 7");
                    }
                    break;
                case 4:
                    System.Console.WriteLine("Saindo...");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}