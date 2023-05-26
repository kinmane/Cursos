/*
 * 21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é
 * positivo ou negativo. Pare a execução do programa quando o usuário requisitar. 
 */

namespace Exer21
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                System.Console.Write("Digite um número: ");
                num = int.Parse(System.Console.ReadLine());

                if (num > 0)
                {
                    System.Console.WriteLine($"O número {num} é positivo.");
                }
                else if (num < 0)
                {
                    System.Console.WriteLine($"O número {num} é negativo.");
                }
                else
                {
                    System.Console.WriteLine($"O número {num} é neutro.");
                }

                System.Console.Write("Deseja continuar? (s/n) ");
                string resp = System.Console.ReadLine();

                if (resp == "n")
                {
                    break;
                }
            }
        }
    }
}