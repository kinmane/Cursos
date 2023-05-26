/*
 * 31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba
 * ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o
 * número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
 * fim dos dados.  
 */

namespace Exer31
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num, somaPar = 0, somaImpar = 0;
            do
            {
                System.Console.Write("Digite um número: ");
                num = int.Parse(System.Console.ReadLine());
                if (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        somaPar += num;
                    }
                    else
                    {
                        somaImpar += num;
                    }
                }
            } while (num > 0);
            System.Console.WriteLine($"Soma dos números pares: {somaPar}");
            System.Console.WriteLine($"Soma dos números ímpares: {somaImpar}");
        }
    }
}