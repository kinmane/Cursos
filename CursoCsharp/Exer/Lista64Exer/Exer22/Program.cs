/*
 * 22) Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o
 * resultado.
 */

namespace Exer22
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int a = 0;
            int b = 0;

            System.Console.Write("Digite um número: ");
            num = int.Parse(System.Console.ReadLine());

            if (num > 0)
            {
                a = num;
                System.Console.WriteLine($"O número {num} é positivo e foi armazenado em A.");
            }
            else
            {
                b = num;
                System.Console.WriteLine($"O número {num} é negativo e foi armazenado em B.");
            }     
        }
    }
}